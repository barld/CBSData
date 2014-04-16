using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogBB;

namespace LogBBTests
{
    /// <summary>
    /// Summary description for LogTests
    /// </summary>
    [TestClass]
    public class LogTests
    {
        private Log l;

        
        public LogTests()
        {
            this.MakeLog();
            this.DeleteLog();
            this.MakeLog();
        }

        [TestMethod]
        public void MakeLog()
        {
            this.l = new Log("unit");
            Assert.IsTrue(System.IO.File.Exists(this.l.LogFile));
            
        }

        [TestMethod]
        public void DeleteLog()
        {
            Assert.IsTrue(this.l.DeleteLogFile());
            Assert.IsFalse(System.IO.File.Exists(this.l.LogFile));
            this.l = null;
        }

        [TestMethod]
        public void AddLogSimpleMessage()
        {
            LogType t = LogType.debug;
            string message = "dit is enkel om te testen";

            //onthou hoe groot het logbestand is. Als het goed is wordt het bestand groter als je er naar schrijft
            long before = (new System.IO.FileInfo(this.l.LogFile)).Length;
            this.l.AddLog(new LogMessage( t, message));
            long after = (new System.IO.FileInfo(this.l.LogFile)).Length;


            //voer hier de check uit
            Assert.IsTrue(before < after, "er zijn geen waardes toegevoegd aan het document");
            Assert.AreEqual(message, l.Messages[l.Messages.Count-1].Message);
                     
        }

        [TestMethod]
        public void AddLogAndMakeMessage()
        {
            this.l.AddLog(LogType.Fetal, "dit is voor de grap fetal");
        }
    }
}
