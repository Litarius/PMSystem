using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PMSystem.Entities
{
    public class Project : BaseEntity
    {
        public Project()
        {
            ManagerUserName = string.Empty;
            ManagerDisplayName = string.Empty;
            CreatorUserName = string.Empty;
            CreatorDisplayName = string.Empty;
            Description = string.Empty;
            Name = string.Empty;
            UploadPath = string.Empty;
        }

        [XmlIgnore]
        public ProjectImage Image { get; set; }

        public bool AllowIssueVoting { get; set; }

        public string Code { get; set; }

        public Guid ManagerId { get; set; }

        public string CreatorUserName { get; set; }

        public string CreatorDisplayName { get; set; }

        public bool Disabled { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public string ManagerUserName { get; set; }

        public string ManagerDisplayName { get; set; }

        public string UploadPath { get; set; }

        public bool AllowAttachments { get; set; }

        public string SvnRepositoryUrl { get; set; }

        public virtual ICollection<IssueType> IssueTypes { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<CustomField> CustomFields { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }

        public virtual ICollection<Milestone> Milestones { get; set; }

        public virtual ICollection<Priority> Priorities { get; set; }

        public virtual ProjectImage ProjectImage { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
