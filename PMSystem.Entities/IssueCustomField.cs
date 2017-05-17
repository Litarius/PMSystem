using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueCustomField
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

        public string DatabaseFieldName { get; set; }
    }
}
