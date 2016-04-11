using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suflow.Common.Utils {
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
        public DatabaseServer Import(string content) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method receives DatabaseServer and convert it to string
        /// 
        /// NOTE: You can use serialize/deserialize of
        ///     https://github.com/Suflow/Suflow.Common.Utils/blob/master/Extension/ObjectExtensions.cs
        /// </summary>
        public string Export(DatabaseServer server) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method receives from and to 
        /// </summary>
        public string GenerateUpgradeScript(DatabaseServer from, DatabaseServer to) {
            throw new NotImplementedException();
        }
    }
}
