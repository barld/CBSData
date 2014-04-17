using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSData
{
    public class TableData
    {
        /// <param name="RawData">hier in komt het object van de database.</param>
        public TableData(List<string> headerData, List<List<object>> rowData)
        {
            this.HeaderData = headerData;
            this.RowData = rowData;
        }

        public List<string> HeaderData
        {
            get;
            set;
        }

        public List<List<object>> RowData
        {
            get;
            set;
        }
    }
}
