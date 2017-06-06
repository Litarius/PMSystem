using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PMSystem.Entities
{
    public class Issue : BaseEntity
    {
        public Issue()
        {
            AssignedDisplayName = string.Empty;
            AssignedUserName = string.Empty;
            LastUpdateUserName = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
            IssueCustomFields = new List<IssueCustomField>();
        }

        public List<IssueCustomField> IssueCustomFields { get; set; }

        public bool IsClosed { get; set; }

        public bool SendNewAssigneeNotification { get; set; }

        public bool NewAssignee { get; set; }

        public int Progress { get; set; }

        public int Votes { get; set; }

        public bool Disabled { get; set; }

        public decimal Estimation { get; set; }

        public double TimeLogged { get; set; }

        public string AssignedDisplayName { get; set; }

        public string AssignedUserName { get; set; }

        public int Visibility { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CreatorDisplayName { get; set; }

        public string CreatorUserName { get; set; }

        public Guid CreatorUserId { get; set; }

        public string OwnerUserName { get; set; }

        public string OwnerDisplayName { get; set; }

        public Guid OwnerUserId { get; set; }

        public Guid AssignedUserId { get; set; }

        public DateTime DateCreated { get; set; }

        [XmlIgnore]
        public string FullId
        {
            get { return string.Concat(ProjectCode, "-", Id); }
        }

        public DateTime LastUpdate { get; set; }

        public DateTime DueDate { get; set; }

        public string LastUpdateDisplayName { get; set; }

        public string LastUpdateUserName { get; set; }

        public int MilestoneId { get; set; }

        public string MilestoneName { get; set; }

        public string MilestoneImageUrl { get; set; }

        public int AffectedMilestoneId { get; set; }

        public string AffectedMilestoneName { get; set; }

        public string AffectedMilestoneImageUrl { get; set; }

        public DateTime? MilestoneDueDate { get; set; }

        public int IssueTypeId { get; set; }

        public string IssueTypeName { get; set; }

        public string IssueTypeImageUrl { get; set; }

        public int ResolutionId { get; set; }

        public string ResolutionName { get; set; }

        public string ResolutionImageUrl { get; set; }

        public int PriorityId { get; set; }

        public string PriorityName { get; set; }

        public string PriorityImageUrl { get; set; }

        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string ProjectCode { get; set; }

        public int StatusId { get; set; }

        public string StatusName { get; set; }

        public string StatusImageUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<IssueAttachment> IssueAttachments { get; set; }
        public virtual ICollection<IssueComment> IssueComments { get; set; }
        public virtual ICollection<IssueNotification> IssueNotifications { get; set; }
        public virtual ICollection<IssueRevision> IssueRevisions { get; set; }
        public virtual ICollection<RelatedIssue> RelatedIssues { get; set; }







        private string EstimationToString(decimal estimation)
        {
            return estimation >= 0 ? estimation.ToString() : "empty";
        }
    }
}
