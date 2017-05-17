using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class CustomField: BaseEntity
    {
        #region Constructors

        public CustomField()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        #endregion

        #region Properties

        public int ProjectId { get; set; }

        public string Name { get; set; }

       // public ValidationDataType DataType { get; set; }

       // public CustomFieldType FieldType { get; set; }

        public bool Required { get; set; }

        public string Value { get; set; }

        #endregion
    }
}
