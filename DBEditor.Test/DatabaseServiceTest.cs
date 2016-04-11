using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBEditor.Service;

namespace DBEditor.Test
{
    [TestClass]
    public class DatabaseServiceTest
    {
        [TestMethod]
        public void TestImportFromString()
        {
            var databaseService = new DatabaseService();
            databaseService.ImportFromString(null);
        }
    }
}
