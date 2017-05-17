using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueRevision : BaseEntity
    {
        public IssueRevision()
        {
            Author = string.Empty;
            Message = string.Empty;
            Repository = string.Empty;
            DateCreated = DateTime.Now;
            RevisionDate = string.Empty;
            Changeset = string.Empty;
            Branch = string.Empty;
        }

        public int IssueId { get; set; }

        public int Revision { get; set; }

        public string Author { get; set; }

        public string Message { get; set; }

        public string Repository { get; set; }

        public string RevisionDate { get; set; }

        public DateTime DateCreated { get; set; }

        public string Branch { get; set; }

        public string Changeset { get; set; }

    }
}
