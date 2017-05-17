using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueCustomField
    {
        [Key]
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

        public string DatabaseFieldName { get; set; }
    }
}
