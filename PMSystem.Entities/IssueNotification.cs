using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueNotification: BaseEntity
    {
        public IssueNotification()
        {
            NotificationUsername = string.Empty;
            NotificationEmail = string.Empty;
            NotificationCulture = "en-US";
        }

        public string NotificationDisplayName { get; set; }

        public int IssueId { get; set; }

        public string NotificationUsername { get; set; }

        public string NotificationEmail { get; set; }

        public string NotificationCulture { get; set; }
    }
}
