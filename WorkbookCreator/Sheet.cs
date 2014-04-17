﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;

namespace WorkbookCreator
{
    public class Sheet
    {
        #region private fields
        private Excel.Worksheet sheet;
        #endregion

        //constructor is internal gemaakt zodat gebruikers niet zomaar zelf objecten kunnen gaan aanmaken
        internal Sheet(string name, List<string> header, List<List<object>>data, ExcelPosition startPosition, Excel.Worksheet  sheet)
        {
            this.Name = name;
            this.HeaderColomns = header;
            this.Data = data;
            this.StarPosition = new ExcelPosition() { X = startPosition.X, Y = startPosition.Y };
            this.HuidigePositie = startPosition;
            this.sheet = sheet;

            this._createSheet();
        }

        //eigenlijk de belangerijkste methode hier is waar het gebeurt
        private void _createSheet()
        {
            this.sheet.Name = this.Name;
            
            //loop door de header data heen en zet die in sheet 
            foreach (string columnName in this.HeaderColomns)
            {
                this.sheet.Cells[this.HuidigePositie.Y, this.HuidigePositie.X] = columnName;
                this.HuidigePositie.X++;
            }
            //reset x
            this.HuidigePositie.X = this.StarPosition.X;
            this.HuidigePositie.Y++;

            //ga nu de daadwekelijk data uitpakken
            foreach (List<object> row in this.Data)
            {
                foreach(object cell in row)
                {
                    this.sheet.Cells[this.HuidigePositie.Y, this.HuidigePositie.X] = cell;
                    this.HuidigePositie.X++;
                }
                this.HuidigePositie.X = this.StarPosition.X;
                this.HuidigePositie.Y++;
            }

            //ale data staat nu zorg dat het beter wordt opgemaakt
            string a = this.sheet.UsedRange.Address;
            this.sheet.Range[a].Columns.AutoFit();
            
            
                


        }

        public ExcelPosition StarPosition
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public ExcelPosition HuidigePositie
        {
            get;
            set;
        }

        public System.Collections.Generic.List<string> HeaderColomns
        {
            get;
            set;
        }

        public List<List<object>> Data
        {
            get;
            set;
        }
    }
}
