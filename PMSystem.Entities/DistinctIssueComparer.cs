using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class DistinctIssueComparer : IEqualityComparer<Issue>
    {
        bool IEqualityComparer<Issue>.Equals(Issue x, Issue y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            return x.Id == y.Id;
        }

        int IEqualityComparer<Issue>.GetHashCode(Issue obj)
        {
            return ReferenceEquals(obj, null) ? 0 : obj.Id.GetHashCode();
        }
    }
}
