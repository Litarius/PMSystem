using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueHistory : BaseEntity
    {
        public IssueHistory()
        {
            CreatedUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            DateChanged = DateTime.Now;
            NewValue = string.Empty;
            OldValue = string.Empty;
            TriggerLastUpdateChange = false;
        }

        public int IssueId { get; set; }

        public string CreatedUserName { get; set; }

        public string FieldChanged { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public DateTime DateChanged { get; set; }

        public string CreatorDisplayName { get; set; }

        public bool TriggerLastUpdateChange { get; set; }
    }
}
