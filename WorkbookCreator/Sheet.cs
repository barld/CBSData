using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkbookCreator
{
    public class Sheet
    {
        public ExcelPosition StarPosition
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ExcelPosition HuidigePositie
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Collections.Generic.List<string> HeaderColomns
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<List<object>> Data
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool WriteToSheet()
        {
            throw new System.NotImplementedException();
        }

        public void AddData(List<string> headerColumns, List<List<object>> data)
        {
            throw new System.NotImplementedException();
        }
    }
}
