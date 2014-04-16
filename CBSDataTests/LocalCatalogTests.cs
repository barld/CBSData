using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CBSData;

namespace CBSDataTests
{
    [TestClass]
    public class LocalCatalogTests
    {
        private LocalCatalog _catalog;

        public LocalCatalogTests()
        {
            this._catalog = new LocalCatalog();
        }

        [TestMethod]
        public void TestSynchroniseren()
        {
            //check altijd eerst voor een connection
            if(this._catalog.CheckServiceConnection())
                this._catalog.SynchronizeDatabase();

        }
    }
}
