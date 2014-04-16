using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using LogBB;
using CBSData;

namespace GUICBSData
{
    internal static class Globals
    {
        #region private fields
        private static Log _log = new Log("GUI");
        //het heeft geen voordeel om hiervan meerder objecten in mijn applicatie te hebben rondzweven
        private static LocalCatalog _localCatalog = new LocalCatalog();
        private static Thread _updateThread;

        //vieze hack omdat ik even een invoke method nodig heb
        public static MainWindow MainWindow = new MainWindow();
        #endregion

        #region public properties
        /// <summary>
        /// log object waar iedereen aan toe kan voegen wat die wilt
        /// </summary>
        public static LogBB.Log Log
        {
            get
            {
                return Globals.Log;
            }
        }

        public static LocalCatalog LocalCatalog
        {
            get
            {
                return Globals._localCatalog;
            }
        }

        #endregion


        #region public methodes

        public static void SychronisserCataloges()
        {

            Globals._updateThread = new Thread(Globals._handelSynchroniseren);

            if(Globals._updateThread.IsAlive == false)
            {
                Globals._updateThread.Start();
            }
        }

        public delegate void ControlStringConsumer();

        private static void report()
        {
            if(MainWindow.InvokeRequired)
                MainWindow.Invoke(new ControlStringConsumer(report), new object[] { });
            else
            {
                //hier mag je weer alles in de main thread doen
                //MainWindow.Text = "test";
                //Log.AddLog(LogType.info, "database is weer bij de tijd");
            }
        }

        private static void _handelSynchroniseren(object obj)
        {
            Globals._localCatalog.SynchronizeDatabase();

            //database is weer synchroon ggef een melding terug aan de gebruiker dat hij klaar is
            System.Windows.Forms.MessageBox.Show("de database is weer synchroon");

            report();
        }

        #endregion





        
    }
}
