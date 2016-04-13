using DBEditor.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEditor.Service.Model
{
    public class DatabaseServerSampleDataFactory
    {
        public static DatabaseServer GetSimpleDatabaseServer()
        {
            var result = new DatabaseServer();
            result.Name = "localhost";
            AddDatabase(result, "database1");
            AddDatabase(result, "database2");
            AddDatabase(result, "database3");
            return result;
        }

        private static void AddDatabase(DatabaseServer databaseServer, string databaseName)
        {
            var database1 = new Database();
            database1.Name = databaseName;
            AddTable(database1, "Table1");
            AddTable(database1, "Table2");
            AddTable(database1, "Table3");

            if (databaseServer.Databases == null)
                databaseServer.Databases = new List<Database>();
            databaseServer.Databases.Add(database1);
        }

        private static void AddTable(Database database, string tableName)
        {
            var table = new DatabaseTable();
            table.Name = tableName;
            AddField(table, "Field1", false, false, "string");
            AddField(table, "Field2", false, false, "string");
            AddField(table, "Field3", false, false, "string");

            if (database.Tables == null)
                database.Tables = new List<DatabaseTable>();
            database.Tables.Add(table);
        }

        private static void AddField(DatabaseTable table, string fieldName, bool isNull, bool isUnique, string dataType)
        {
            var field = new DatabaseField();
            field.Name = fieldName;
            field.IsNull = isNull;
            field.IsUnique = isUnique;
            field.DataType = dataType;

            if (table.Fields == null)
                table.Fields = new List<DatabaseField>();
            table.Fields.Add(field);
        }
    }
}
