using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEditor.Service.Model
{
    public class Database {
        public string Name { get; set; }
        public ICollection<DatabaseTable> Tables { get; set; }
    }
}
