using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSData
{
    internal static class Globals
    {

        private static LogBB.Log _log = new LogBB.Log("CBSData");

        public static LogBB.Log Log
        {
            get
            {
                return Globals._log;
            }
        }
    }
}
