using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueType: BaseEntity
    {
        public IssueType()
        {
            Name = string.Empty;
            ImageUrl = string.Empty;
        }
        
        public string Name { get; set; }

        public int SortOrder { get; set; }

        public int ProjectId { get; set; }

        public string ImageUrl { get; set; }
    }
}
