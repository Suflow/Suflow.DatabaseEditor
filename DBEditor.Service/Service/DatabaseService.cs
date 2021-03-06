using DBEditor.Service.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEditor.Service
{
    /// <summary>
    /// Feel free to refactor (add/remove/rename) as per need!
    /// Create unit test to test each service method
    /// </summary>
    public class DatabaseService {
        /// <summary>
        /// This method receives string representation of database server and convert it to
        /// database server object.
        /// 
        /// NOTE: You can use serialize/deserialize of
        ///     https://github.com/Suflow/Suflow.Common.Utils/blob/master/Extension/ObjectExtensions.cs
        /// </summary>
        public DatabaseServer ImportFromString(string xmlContent) {
            var server = new DatabaseServer();
            server = server.DeserializeFromXml<DatabaseServer>(xmlContent, Encoding.Unicode);
            return server;
        }

        /// <summary>
        /// This method receives database Server information (server name, user, password and databases)
        /// And connects to the server and create corresponding database server object out of it.
        /// databases is empty, it will consider all databases
        /// </summary>
        public DatabaseServer ImportFromServer(string databaseServer, string user, string password, string[] databases) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method receives DatabaseServer and convert it to string
        /// 
        /// NOTE: You can use serialize/deserialize of
        ///     https://github.com/Suflow/Suflow.Common.Utils/blob/master/Extension/ObjectExtensions.cs
        /// </summary>
        public string ExportToString(DatabaseServer server) {
            //var xmlContent1 = ObjectExtensions.SerializeToXml(server, Encoding.Unicode);
            var xmlContent = server.SerializeToXml(Encoding.Unicode);
            return xmlContent;
        }

        public void ExportToFile(DatabaseServer server, string filePath)
        {
            //var xmlContent1 = ObjectExtensions.SerializeToXml(server, Encoding.Unicode);
            var xmlContent = ExportToString(server);
            File.WriteAllText(filePath, xmlContent);
        }

        /// <summary>
        /// This method receives from and to and generate upgrade script in SQL
        /// </summary>
        public string GenerateUpgradeScript(DatabaseServer from, DatabaseServer to) {
            throw new NotImplementedException();
        } 

        /// <summary>
        /// This method receives database server object and export it to real server
        /// 
        /// </summary>
        /// <param name="server"></param>
        public void UpgradeServer(DatabaseServer server) {
        }
    }
}
