using System;

namespace PMSystem.Entities
{
    public class RelatedIssue
    {
        public RelatedIssue()
        {
            Status = string.Empty;
            Resolution = string.Empty;
            Title = string.Empty;
            DateCreated = DateTime.Now;
        }

        public DateTime DateCreated { get; set; }

        public int IssueId { get; set; }

        public string Status { get; set; }

        public string StatusName { get; set; }

        public string StatusImageUrl { get; set; }

        public string Resolution { get; set; }

        public string Title { get; set; }
    }
}
