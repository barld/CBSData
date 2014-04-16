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
        public int CountTables
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int CountThemes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<LocalCatalogTable> Tables
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<LocalCatalogTheme> Themes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DataBase DB
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
    }
}
