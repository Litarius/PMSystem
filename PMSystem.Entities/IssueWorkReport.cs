using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueWorkReport:BaseEntity
    {
        public IssueWorkReport()
        {
            CommentText = string.Empty;
            CreatorUserName = string.Empty;
            WorkDate = DateTime.Now;
            CreatorDisplayName = string.Empty;
        }

        public int IssueId { get; set; }

        public decimal Duration { get; set; }

        public string CommentText { get; set; }

        public int CommentId { get; set; }

        public DateTime WorkDate { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public Guid CreatorUserId { get; set; }
    }
}

