using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class LocalCatalogTheme : OdataCatalog.Theme
    {
        private OdataCatalog.Theme x;
        private localDBDataSet.ThemeRow x1;

        public LocalCatalogTheme(OdataCatalog.Theme old)
        {
            // TODO: Complete member initialization
            this.x = old;

            this.ID = old.ID;
            this.Number = old.Number;
            this.Title = old.Title;
        }

        public LocalCatalogTheme(localDBDataSet.ThemeRow old)
        {
            this.ID = old.ID;
            this.Number = old.Number;
            this.Title = old.Title;
        }

        public LocalCatalogTheme()
        {
            // TODO: Complete member initialization
        }
        public void GetTables()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
