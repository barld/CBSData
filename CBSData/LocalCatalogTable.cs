using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class LocalCatalogTable : OdataCatalog.Table
    {
        private localDBDataSet.TableRow x;
        private TableManager _tableManeger;


        public TableManager TableManeger
        {
            get
            {
                if(this._tableManeger==null)
                    this._tableManeger = new TableManager(string.Format("http://opendata.cbs.nl/OData3StatlineBulkService/{0}/", this.Identifier.Replace(" ", "")));
                return this._tableManeger;
            }
        }
    
        /// <summary>
        /// cast parent naar child
        /// </summary>
        public LocalCatalogTable(OdataCatalog.Table old)
        {
            this.ID = old.ID;
            this.Identifier = old.Identifier;
            this.Title = old.Title;
            this.ShortTitle = old.ShortTitle;
            this.Summary = old.Summary;
            this.Modified = old.Modified;
            this.ReasonDelivery = old.ReasonDelivery;
            this.Language = old.Language;
            this.Frequency = old.Frequency;
            this.DefaultSettings = old.DefaultSettings;
            this.DefaultSelection = old.DefaultSelection;
            this.initial();

        }

        public LocalCatalogTable(localDBDataSet.TableRow old)
        {
            this.ID = old.ID;
            this.Identifier = old.identifier;
            this.Title = old.title;
            this.ShortTitle = old.shorttitle;
            this.Summary = old.summary;
            this.Modified = old.modified;
            this.ReasonDelivery = old.reasondelivery;
            this.Language = old.language;
            this.Frequency = old.Frequency;
            this.DefaultSettings = old.defaultsettings;
            this.DefaultSelection = old.defaultselection;
            this.initial();

        }

        public LocalCatalogTable()
        {
            this.initial();
        }

        private void initial()
        {
            //this._tableManeger = ;//er komenen wel eens spaties in voor die worden hier verwijdert
        }

        public void GetThemes()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataRow ToDataRow()
        {
            localDBDataSet.TableDataTable tab = new localDBDataSet.TableDataTable();
            DataRow rtw = tab.NewRow();

            //vul de datarow
            rtw["ID"] = this.ID;
            rtw["Identifier"] = this.Identifier;
            rtw["Title"] = this.Title;
            rtw["ShortTitle"] = this.ShortTitle;
            rtw["Summary"] = this.Summary;
            rtw["Modified"] = this.Modified;
            rtw["ReasonDelivery"] = this.ReasonDelivery;
            rtw["Language"] = this.Language;
            rtw["Frequency"] = this.Frequency;
            rtw["Period"] = this.Period;
            rtw["DefaultSettings"] = this.DefaultSettings;
            rtw["DefaultSelection"] = this.DefaultSelection;

            return rtw;
        }

        #region override
        public override string ToString()
        {
            return this.Title;
        }

        #endregion
    }
}
