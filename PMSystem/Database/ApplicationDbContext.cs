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

        public IDbSet<IssueAttachment> IssueAttachments { get; set; }

        public IDbSet<IssueComment> IssueComments { get; set; }

        public IDbSet<IssueHistory> IssueHistory { get; set; }

        public IDbSet<IssueNotification> IssueNotifications { get; set; }

        public IDbSet<IssueRevision> IssueRevisions { get; set; }

        public IDbSet<Issue> Issues { get; set; }

        public IDbSet<Permission> Permissions { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<ProjectStatus> ProjectStatus { get; set; }


    }
}