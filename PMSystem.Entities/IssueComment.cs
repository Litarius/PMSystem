using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueComment : BaseEntity
    {
        public IssueComment()
        {
            CreatorUserName = string.Empty;
            Comment = string.Empty;
            CreatorDisplayName = string.Empty;
            DateCreated = DateTime.Now;
        }

        public Guid CreatorUserId { get; set; }

        public string Comment { get; set; }

        public string CommentForXml
        {
            get { return string.Format("<![CDATA[{0}]]>", string.IsNullOrEmpty(Comment) ? string.Empty : Comment); }
            set { }
        }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public DateTime DateCreated { get; set; }

        public int IssueId { get; set; }

    }
}
