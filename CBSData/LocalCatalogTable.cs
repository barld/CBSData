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

        public TableManager TableManeger
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
