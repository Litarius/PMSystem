using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class ProjectStatus: BaseEntity
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public bool IsClosedState { get; set; }
    }
}
