using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEditor.Service.Model
{
    public class DatabaseServer
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Database> Databases { get; set; }
    }
}
