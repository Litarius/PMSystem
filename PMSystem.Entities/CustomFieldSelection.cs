using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class CustomFieldSelection: BaseEntity
    {
        public CustomFieldSelection()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        #region Properties

        public int CustomFieldId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int SortOrder { get; set; }

        #endregion
    }
}
