using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogBB;

namespace LogBBTests
{
    [TestClass]
    public class LogMessageTests
    {
        private LogMessage _message;
        /// <summary>
        /// constructor
        /// </summary>
        public LogMessageTests()
        {
            this.TestLogMessageConstructorMetArgumenten();
        }

        [TestMethod]
        public void TestLogMessageConstructorMetArgumenten()
        {
            this._message = new LogMessage(LogType.Fetal, "bericht");
            Assert.IsNotNull(this._message);
        }

        public void TestDefaultValues()
        {
            //kijken of er een recente test is uitgevoerd
            Assert.IsTrue(DateTime.Now - this._message.Time < new TimeSpan(0, 1, 0));
        }
    }
}
