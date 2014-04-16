using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class LocalCatalogTheme : OdataCatalog.Theme
    {
        private OdataCatalog.Theme x;

        public LocalCatalogTheme(OdataCatalog.Theme old)
        {
            // TODO: Complete member initialization
            this.x = old;

            this.ID = old.ID;
            this.Number = old.Number;
            this.Title = old.Title;
        }
        public void GetTables()
        {
            throw new System.NotImplementedException();
        }
    }
}
