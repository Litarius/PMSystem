using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueVote
    {
        public IssueVote()
        {
            VoteUsername = string.Empty;
        }

        public int Id { get; set; }

        public int IssueId { get; set; }

        public string VoteUsername { get; set; }
    }
}
