using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class Category : BaseEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {
            Name = string.Empty;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public int ProjectId { get; set; }

        public int ChildCount { get; set; }

        public int ParentCategoryId { get; set; }

        public int IssueCount { get; set; }

        public bool Disabled { get; set; }

        #endregion
    }
}
