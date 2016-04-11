using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEditor.Service.Model
{
    public class DatabaseTable
    {
        public string TableName { get; set; }
        public ICollection<DatabaseField> DatabaseFields { get; set; }
    }
}
