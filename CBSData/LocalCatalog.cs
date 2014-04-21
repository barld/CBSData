using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class LocalCatalog
    {

        #region private fields 
        private DataBase _db = new DataBase();

        #endregion


        public List<LocalCatalogTable> Tables
        {
            get
            {
                localDBDataSetTableAdapters.TableTableAdapter t = new localDBDataSetTableAdapters.TableTableAdapter();
                return t.GetData().Select(x => new LocalCatalogTable(x)).ToList();
            }
        }

        /// <summary>
        /// geeft alle thema's uit de database terug
        /// </summary>
        public List<LocalCatalogTheme> Themes
        {
            get
            {
                localDBDataSetTableAdapters.ThemeTableAdapter t = new localDBDataSetTableAdapters.ThemeTableAdapter();
                return t.GetData().Select(x => new LocalCatalogTheme(x)).ToList();
            }
        }

        public DataBase DB
        {
            get
            {
                return this._db;
            }
        }

        //ggeft de datum van het nieuwste item in de database weer
        public DateTime LastUpdated()
        {
            localDBDataSetTableAdapters.TableTableAdapter tb = new localDBDataSetTableAdapters.TableTableAdapter();
            if (tb.GetData().Count > 0)
                return tb.GetData().Max(x => x.modified);
            else
                return new DateTime(0);
        }
    
        public bool CheckServiceConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (var stream = client.OpenRead("http://opendata.cbs.nl/OData3StatlineCatalogService/Catalog/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public bool SynchronizeDatabase()
        {
            #region testen
            /*OdataCatalog.Catalog c = new OdataCatalog.Catalog(new Uri(@"http://opendata.cbs.nl/OData3StatlineCatalogService/Catalog/"));
            OdataCatalog.Table t = new OdataCatalog.Table();
            var ad = new localDBDataSetTableAdapters.TableTableAdapter();

            string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\localDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection db = new SqlConnection(connectionstring);
            SqlCommand cmd = db.CreateCommand();
            db.Open();
            cmd.CommandText = "SELECT 2*2 AS result";
            var result = cmd.ExecuteReader();

            result.Read();

            var antwoord = result[0];*/
            #endregion

            DateTime lastmodified = this.LastUpdated();

            OdataCatalog.Catalog c = new OdataCatalog.Catalog(new Uri(@"http://opendata.cbs.nl/OData3StatlineCatalogService/Catalog/"));

            //tables
            var tables = c.Tables.Where(x => x.Modified > lastmodified);

            var tablerows = from trow in tables.ToList().Select(x=>new LocalCatalogTable(x))
                       select trow;

            var tab = new localDBDataSetTableAdapters.TableTableAdapter();
            foreach(var row in tablerows)
            {
                try
                {
                    tab.Insert(
                        row.ID,
                        row.Identifier,
                        row.Title,
                        row.ShortTitle,
                        row.Summary,
                        row.Modified.Value,
                        row.ReasonDelivery,
                        row.Language,
                        row.Period,
                        row.SummaryAndLinks,
                        row.DefaultSettings,
                        row.DefaultSelection,
                        row.Frequency);
                }
                catch
                {
                    tab.Update(row.ToDataRow());
                }
            }

            //thema
            var themes = c.Themes;
            var themerows =
                from themrow in themes.ToList().Select(x => new LocalCatalogTheme(x))
                select themrow;

            var them = new localDBDataSetTableAdapters.ThemeTableAdapter();
            foreach(var themerow in themerows)
            {
                try
                {
                    them.Insert(themerow.ID, themerow.Number, themerow.Title);
                }
                catch
                {
                    /*var updatedata = them.GetData().Where(x => x.ID == themerow.ID).First();
                    updatedata.Number = themerow.Number;
                    updatedata.Title = themerow.Title;
                    them.Update(updatedata);*/
                }
            }

            var tabthems = c.Tables_Themes;
            var tabthemrows =
                from tabthemrow in tabthems.ToList().Select(x=>new LocalCatalogTableTheme(x))
                select tabthemrow;

            var tabthem = new localDBDataSetTableAdapters.Table_ThemeTableAdapter();
            foreach(var tabthemrow in tabthemrows)
            {
                try
                {
                    tabthem.Insert(
                        tabthemrow.ID,
                        tabthemrow.TableID,
                        tabthemrow.ThemeID
                        );
                }
                catch
                {
                    /*tabthem.Update(
                        )*/
                }
            }

            return true;
        }

        public System.Collections.Generic.List<LocalCatalogTable> GetTablesWhereAnd()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<LocalCatalogTable> GetTablesWhereOr()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// return een array aan items op basis van een like op de title
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public LocalCatalogTable[] GetTablesWhere(string searchTable, string searchTheme)
        {
            string sql = @"
select [Table].*, [Theme].Title from [Table]
	INNER JOIN [Table_Theme] ON [Table_Theme].TableID=[Table].ID
	INNER JOIN [Theme] on [Table_Theme].ThemeID = [Theme].ID
WHERE 
	[Table].title LIKE @searchTable
	AND [Theme].Title LIKE @searchTheme
";
            Dictionary<string,string> vars = new Dictionary<string,string>();
            vars.Add("@searchTable", "%"+searchTable+"%");
            vars.Add("@searchTheme", "%" + searchTheme + "%");
            var result = this.DB.Select(sql, vars);

            //cast de resultaten naar LocalCatalogTable objects
            LocalCatalogTable[] rtw = new LocalCatalogTable[result.Count];

            int i = 0;
            foreach (Dictionary<string, object> row in result)
            {
                LocalCatalogTable table = new LocalCatalogTable();

                table.ID = Convert.ToInt32(row["ID"]);
                table.Identifier = row["identifier"] as string;
                table.Title = row["title"] as string;
                table.ShortTitle = row["shorttitle"] as string;
                table.Summary = row["summary"] as string;
                table.Modified = row["modified"] as DateTime?;
                table.ReasonDelivery = row["reasondelivery"] as string;
                table.Language = row["language"] as string;
                table.Period = row["period"] as string;
                table.SummaryAndLinks = row["summaryandlinks"] as string;
                table.DefaultSettings = row["defaultsettings"] as string;
                table.Frequency = row["Frequency"] as string;

                rtw[i] = table;
                i++;
            }

            

            return rtw;
        }

        /// <summary>
        /// geeft de reultaten aan thema's terug op basis van een searchquery in de mdf file
        /// </summary>
        /// <param name="searchTheme"></param>
        /// <returns></returns>
        public LocalCatalogTheme[] GetThemsWhere(string searchTheme)
        {
            string sql = @"
select * from [Theme]
WHERE 
	[Theme].Title LIKE @searchTheme
";
            Dictionary<string, string> vars = new Dictionary<string, string>();
            vars.Add("@searchTheme", "%"+searchTheme+"%");

            var result = this._db.Select(sql, vars);

            LocalCatalogTheme[] rtw = new LocalCatalogTheme[result.Count];
            int i = 0;
            foreach (Dictionary<string,object> row in result)
            {
                LocalCatalogTheme temp = new LocalCatalogTheme();
                temp.ID = Convert.ToInt32(row["ID"]);
                temp.Number = row["Number"] as string;
                temp.Title = row["Title"] as string;

                rtw[i] = temp;
                i++;
            }

            return rtw;

        }
    }
}
