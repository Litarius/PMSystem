using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueComment
    {
        #region Constructors

        public IssueComment()
        {
            CreatorUser = new ITUser(new Guid(), string.Empty, string.Empty);
            CreatorUserName = string.Empty;
            Comment = string.Empty;
            CreatorDisplayName = string.Empty;
            DateCreated = DateTime.Now;
        }

        #endregion

        #region Properties

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

        public int Id { get; set; }

        public int IssueId { get; set; }

        public ITUser CreatorUser { get; set; }

        #endregion
    }
}
