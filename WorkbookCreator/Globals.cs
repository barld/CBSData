using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkbookCreator
{
    internal static class Globals
    {
        private static LogBB.Log _log = new LogBB.Log("Workbook");

        public static LogBB.Log Log
        {
            get
            {
                return Globals._log;
            }
        }
    }
}
