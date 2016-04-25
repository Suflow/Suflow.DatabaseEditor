using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBEditor.Service;

namespace DBEditor.Test
{
    [TestClass]
    public class DatabaseServiceTest
    {
        [TestMethod]
        public void TestExportToString()
        {
            var databaseServer = DatabaseServerSampleDataFactory.GetSimpleDatabaseServer();
            var databaseService = new DatabaseService();
            var databaseServerXml = databaseService.ExportToString(databaseServer);
        }

        [TestMethod]
        public void TestImportFromString()
        {
            var databaseServer = DatabaseServerSampleDataFactory.GetSimpleDatabaseServer();
            var databaseService = new DatabaseService();
            var databaseServerXml = databaseService.ExportToString(databaseServer);
            var databaseServerImport = databaseService.ImportFromString(databaseServerXml);
        }
    }

}
