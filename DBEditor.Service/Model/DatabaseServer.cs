using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DBEditor.Service.Model
{
    public class DatabaseServer
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Database> Databases { get; set; }

    [XmlIgnore]
        public string Xml { get { return new DatabaseService().ExportToString(this);} }
    }

   
}
