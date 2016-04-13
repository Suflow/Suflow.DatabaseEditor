using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEditor.Service.Model
{
    public class DatabaseTable
    {
        public string Name { get; set; }
        public ICollection<DatabaseField> Fields { get; set; }
    }
}
