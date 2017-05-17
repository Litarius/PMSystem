using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using PMSystem.Entities;

namespace PMSystem.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<ApplicationLog> ApplicationLogs { get; set; }

        public IDbSet<DefaultValue> DefaultValues { get; set; }

        public IDbSet<HostSetting> HostSettings { get; set; }

        public IDbSet<IssueAttachment> IssueAttachments { get; set; }

        public IDbSet<IssueComment> IssueComments { get; set; }

        public IDbSet<IssueHistory> IssueHistory { get; set; }

        public IDbSet<IssueNotification> IssueNotifications { get; set; }

        public IDbSet<IssueRevision> IssueRevisions { get; set; }

        public IDbSet<Issue> Issues { get; set; }

        public IDbSet<IssueVote> IssueVotes { get; set; }

        public IDbSet<IssueWorkReport> IssueWorkReports { get; set; }

        public IDbSet<Permission> Permissions { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<ProjectStatus> ProjectStatus { get; set; }


    }
}