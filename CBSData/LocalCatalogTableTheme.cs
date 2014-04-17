using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class LocalCatalogTableTheme : OdataCatalog.Table_Theme
    {
        private OdataCatalog.Table_Theme x;
        private localDBDataSet.ThemeRow x1;

        public LocalCatalogTableTheme(OdataCatalog.Table_Theme parent)
        {
            this.x = parent;

            this.ID = parent.ID;
            this.TableID = parent.TableID;
            this.ThemeID = parent.ThemeID;
        }

        public LocalCatalogTableTheme(localDBDataSet.ThemeRow x1)
        {
            // TODO: Complete member initialization
            this.x1 = x1;
        }
    }
}
