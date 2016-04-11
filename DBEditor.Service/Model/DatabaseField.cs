using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBEditor.Service.Model
{
    public class DatabaseField
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public bool IsNull { get; set; }
        public bool IsUnique { get; set; }
    }
}
