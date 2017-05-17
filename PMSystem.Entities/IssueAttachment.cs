using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueAttachment
    {
        #region Constructors

        public IssueAttachment()
        {
            CreatorUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            FileName = string.Empty;
            ContentType = string.Empty;
            DateCreated = DateTime.Now;
            Description = string.Empty;
        }

        #endregion

        #region Properties

        public int Id { get; set; }

        public int IssueId { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public DateTime DateCreated { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }

        public byte[] Attachment { get; set; }

        public int Size { get; set; }

        public string Description { get; set; }

        public string ProjectFolderPath { get; set; }

        #endregion
    }

}
