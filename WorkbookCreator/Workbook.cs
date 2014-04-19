using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;

namespace WorkbookCreator
{
    public class Workbook
    {
        private Excel.Workbook MyBook = null;
        private Excel.Application MyApp = null;

        public Workbook()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Add(1);

        }

        public List<Sheet> Sheets
        {
            get;
            set;
        }


        /// <summary>
        /// DIt is zeer belangerijk belangerijk de applicatie excel wordt zichtbaar gemaakt en de objecten van excel worden opgeruimd
        /// </summary>
        /// <remarks>
        /// Dit wordt niet standaard afgehandelt door garbace controller
        /// </remarks>
        public bool Vissable
        {
            get
            {
                return this.MyApp.Visible;
            }
            set
            {
                this.MyApp.Visible = value;
                if(value)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(this.MyBook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(this.MyApp);
                }
            }
        }

        public string File
        {
            get;
            set;
        }

        public Sheet GetSheet(string name, List<string> header, List<List<object>> data)
        {
            this.MyBook.Sheets.Add();
            Excel.Worksheet s = this.MyBook.Sheets[this.MyBook.Sheets.Count - 1];
            return new Sheet(name, header, data, new ExcelPosition() { X = 2, Y = 2 }, s);
        }

        //ruim alle rommel weer op
        ~Workbook()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.MyBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(this.MyApp);
        }
    }
}
