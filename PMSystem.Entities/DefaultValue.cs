using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class DefaultValue
    {
        public bool StatusVisibility { get; set; }

        public bool OwnedByVisibility { get; set; }

        public bool PriorityVisibility { get; set; }

        public bool AssignedToVisibility { get; set; }

        public bool PrivateVisibility { get; set; }

        public bool CategoryVisibility { get; set; }

        public bool DueDateVisibility { get; set; }

        public bool TypeVisibility { get; set; }

        public bool PercentCompleteVisibility { get; set; }

        public bool MilestoneVisibility { get; set; }

        public bool EstimationVisibility { get; set; }

        public bool ResolutionVisibility { get; set; }

        public bool AffectedMilestoneVisibility { get; set; }

        public bool StatusEditVisibility { get; set; }

        public bool OwnedByEditVisibility { get; set; }

        public bool PriorityEditVisibility { get; set; }

        public bool AssignedToEditVisibility { get; set; }

        public bool PrivateEditVisibility { get; set; }

        public bool CategoryEditVisibility { get; set; }

        public bool DueDateEditVisibility { get; set; }

        public bool TypeEditVisibility { get; set; }

        public bool PercentCompleteEditVisibility { get; set; }

        public bool MilestoneEditVisibility { get; set; }

        public bool EstimationEditVisibility { get; set; }

        public bool ResolutionEditVisibility { get; set; }

        public bool AffectedMilestoneEditVisibility { get; set; }

        public bool AssignedToNotify { get; set; }

        public bool OwnedByNotify { get; set; }

        public int IssueVisibility { get; set; }

        public int CategoryId { get; set; }

        public string OwnerUserName { get; set; }

        public string AssignedUserName { get; set; }

        public int MilestoneId { get; set; }

        public int AffectedMilestoneId { get; set; }

        public int IssueTypeId { get; set; }

        public int ResolutionId { get; set; }

        public int PriorityId { get; set; }

        public int ProjectId { get; set; }

        public int StatusId { get; set; }

        public int? DueDate { get; set; }

        public decimal Estimation { get; set; }

        public int Progress { get; set; }

    }
}
