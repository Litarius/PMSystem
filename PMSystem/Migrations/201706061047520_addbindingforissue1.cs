namespace PMSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbindingforissue1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IssueComments", "CreatorUserId", "dbo.ITUsers");
            DropForeignKey("dbo.Issues", "AssignedUserId", "dbo.ITUsers");
            DropForeignKey("dbo.DefaultValues", "Project_Id", "dbo.Projects");
            DropIndex("dbo.DefaultValues", new[] { "Project_Id" });
            DropIndex("dbo.IssueComments", new[] { "CreatorUserId" });
            DropIndex("dbo.Issues", new[] { "AssignedUserId" });
            CreateTable(
                "dbo.RelatedIssues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        Status = c.String(),
                        StatusName = c.String(),
                        StatusImageUrl = c.String(),
                        Resolution = c.String(),
                        Title = c.String(),
                        Issue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.Issue_Id)
                .Index(t => t.Issue_Id);
            
            CreateIndex("dbo.IssueAttachments", "IssueId");
            CreateIndex("dbo.IssueComments", "IssueId");
            CreateIndex("dbo.IssueNotifications", "IssueId");
            CreateIndex("dbo.IssueRevisions", "IssueId");
            AddForeignKey("dbo.IssueAttachments", "IssueId", "dbo.Issues", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IssueComments", "IssueId", "dbo.Issues", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IssueNotifications", "IssueId", "dbo.Issues", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IssueRevisions", "IssueId", "dbo.Issues", "Id", cascadeDelete: true);
            DropTable("dbo.ApplicationLogs");
            DropTable("dbo.DefaultValues");
            DropTable("dbo.HostSettings");
            DropTable("dbo.ITUsers");
            DropTable("dbo.IssueVotes");
            DropTable("dbo.IssueWorkReports");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IssueWorkReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        Duration = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CommentText = c.String(),
                        CommentId = c.Int(nullable: false),
                        WorkDate = c.DateTime(nullable: false),
                        CreatorUserName = c.String(),
                        CreatorDisplayName = c.String(),
                        CreatorUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IssueVotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        VoteUsername = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ITUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        UserName = c.String(),
                        Email = c.String(),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HostSettings",
                c => new
                    {
                        SettingName = c.String(nullable: false, maxLength: 128),
                        SettingValue = c.String(),
                    })
                .PrimaryKey(t => t.SettingName);
            
            CreateTable(
                "dbo.DefaultValues",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        StatusVisibility = c.Boolean(nullable: false),
                        OwnedByVisibility = c.Boolean(nullable: false),
                        PriorityVisibility = c.Boolean(nullable: false),
                        AssignedToVisibility = c.Boolean(nullable: false),
                        PrivateVisibility = c.Boolean(nullable: false),
                        CategoryVisibility = c.Boolean(nullable: false),
                        DueDateVisibility = c.Boolean(nullable: false),
                        TypeVisibility = c.Boolean(nullable: false),
                        PercentCompleteVisibility = c.Boolean(nullable: false),
                        MilestoneVisibility = c.Boolean(nullable: false),
                        EstimationVisibility = c.Boolean(nullable: false),
                        ResolutionVisibility = c.Boolean(nullable: false),
                        AffectedMilestoneVisibility = c.Boolean(nullable: false),
                        StatusEditVisibility = c.Boolean(nullable: false),
                        OwnedByEditVisibility = c.Boolean(nullable: false),
                        PriorityEditVisibility = c.Boolean(nullable: false),
                        AssignedToEditVisibility = c.Boolean(nullable: false),
                        PrivateEditVisibility = c.Boolean(nullable: false),
                        CategoryEditVisibility = c.Boolean(nullable: false),
                        DueDateEditVisibility = c.Boolean(nullable: false),
                        TypeEditVisibility = c.Boolean(nullable: false),
                        PercentCompleteEditVisibility = c.Boolean(nullable: false),
                        MilestoneEditVisibility = c.Boolean(nullable: false),
                        EstimationEditVisibility = c.Boolean(nullable: false),
                        ResolutionEditVisibility = c.Boolean(nullable: false),
                        AffectedMilestoneEditVisibility = c.Boolean(nullable: false),
                        AssignedToNotify = c.Boolean(nullable: false),
                        OwnedByNotify = c.Boolean(nullable: false),
                        IssueVisibility = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        OwnerUserName = c.String(),
                        AssignedUserName = c.String(),
                        MilestoneId = c.Int(nullable: false),
                        AffectedMilestoneId = c.Int(nullable: false),
                        IssueTypeId = c.Int(nullable: false),
                        ResolutionId = c.Int(nullable: false),
                        PriorityId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        DueDate = c.Int(),
                        Estimation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Progress = c.Int(nullable: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.ApplicationLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Thread = c.String(maxLength: 250),
                        Level = c.String(maxLength: 50),
                        User = c.String(),
                        Logger = c.String(maxLength: 250),
                        Message = c.String(),
                        Exception = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.RelatedIssues", "Issue_Id", "dbo.Issues");
            DropForeignKey("dbo.IssueRevisions", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.IssueNotifications", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.IssueComments", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.IssueAttachments", "IssueId", "dbo.Issues");
            DropIndex("dbo.RelatedIssues", new[] { "Issue_Id" });
            DropIndex("dbo.IssueRevisions", new[] { "IssueId" });
            DropIndex("dbo.IssueNotifications", new[] { "IssueId" });
            DropIndex("dbo.IssueComments", new[] { "IssueId" });
            DropIndex("dbo.IssueAttachments", new[] { "IssueId" });
            DropTable("dbo.RelatedIssues");
            CreateIndex("dbo.Issues", "AssignedUserId");
            CreateIndex("dbo.IssueComments", "CreatorUserId");
            CreateIndex("dbo.DefaultValues", "Project_Id");
            AddForeignKey("dbo.DefaultValues", "Project_Id", "dbo.Projects", "Id");
            AddForeignKey("dbo.Issues", "AssignedUserId", "dbo.ITUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IssueComments", "CreatorUserId", "dbo.ITUsers", "Id", cascadeDelete: true);
        }
    }
}
