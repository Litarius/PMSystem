using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class IssueCount
    {
        public IssueCount(object id, string name, int count, string imageUrl, decimal percentage = -1)
        {
            Id = id;
            Name = name;
            Count = count;
            ImageUrl = imageUrl;
            Percentage = percentage;

        }

        public object Id { get; private set; }

        public int Count { get; private set; }

        public string Name { get; private set; }

        public string ImageUrl { get; private set; }

        public decimal Percentage { get; set; }
    }
}
