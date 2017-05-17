namespace PMSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_new_tables : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.HostSettings",
                c => new
                    {
                        SettingName = c.String(nullable: false, maxLength: 128),
                        SettingValue = c.String(),
                    })
                .PrimaryKey(t => t.SettingName);
            
            CreateTable(
                "dbo.IssueAttachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        CreatorUserName = c.String(),
                        CreatorDisplayName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        FileName = c.String(),
                        ContentType = c.String(),
                        Attachment = c.Binary(),
                        Size = c.Int(nullable: false),
                        Description = c.String(),
                        ProjectFolderPath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IssueComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatorUserId = c.Guid(nullable: false),
                        Comment = c.String(),
                        CommentForXml = c.String(),
                        CreatorUserName = c.String(),
                        CreatorDisplayName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        IssueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ITUsers", t => t.CreatorUserId, cascadeDelete: true)
                .Index(t => t.CreatorUserId);
            
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
                "dbo.IssueHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        CreatedUserName = c.String(),
                        FieldChanged = c.String(),
                        OldValue = c.String(),
                        NewValue = c.String(),
                        DateChanged = c.DateTime(nullable: false),
                        CreatorDisplayName = c.String(),
                        TriggerLastUpdateChange = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IssueNotifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NotificationDisplayName = c.String(),
                        IssueId = c.Int(nullable: false),
                        NotificationUsername = c.String(),
                        NotificationEmail = c.String(),
                        NotificationCulture = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IssueRevisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        Revision = c.Int(nullable: false),
                        Author = c.String(),
                        Message = c.String(),
                        Repository = c.String(),
                        RevisionDate = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Branch = c.String(),
                        Changeset = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsClosed = c.Boolean(nullable: false),
                        SendNewAssigneeNotification = c.Boolean(nullable: false),
                        NewAssignee = c.Boolean(nullable: false),
                        Progress = c.Int(nullable: false),
                        Votes = c.Int(nullable: false),
                        Disabled = c.Boolean(nullable: false),
                        Estimation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TimeLogged = c.Double(nullable: false),
                        AssignedDisplayName = c.String(),
                        AssignedUserName = c.String(),
                        Visibility = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CategoryName = c.String(),
                        CreatorDisplayName = c.String(),
                        CreatorUserName = c.String(),
                        CreatorUserId = c.Guid(nullable: false),
                        OwnerUserName = c.String(),
                        OwnerDisplayName = c.String(),
                        OwnerUserId = c.Guid(nullable: false),
                        AssignedUserId = c.Guid(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        LastUpdateDisplayName = c.String(),
                        LastUpdateUserName = c.String(),
                        MilestoneId = c.Int(nullable: false),
                        MilestoneName = c.String(),
                        MilestoneImageUrl = c.String(),
                        AffectedMilestoneId = c.Int(nullable: false),
                        AffectedMilestoneName = c.String(),
                        AffectedMilestoneImageUrl = c.String(),
                        MilestoneDueDate = c.DateTime(),
                        IssueTypeId = c.Int(nullable: false),
                        IssueTypeName = c.String(),
                        IssueTypeImageUrl = c.String(),
                        ResolutionId = c.Int(nullable: false),
                        ResolutionName = c.String(),
                        ResolutionImageUrl = c.String(),
                        PriorityId = c.Int(nullable: false),
                        PriorityName = c.String(),
                        PriorityImageUrl = c.String(),
                        ProjectId = c.Int(nullable: false),
                        ProjectName = c.String(),
                        ProjectCode = c.String(),
                        StatusId = c.Int(nullable: false),
                        StatusName = c.String(),
                        StatusImageUrl = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        MilestoneSortOrder = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ITUsers", t => t.AssignedUserId, cascadeDelete: true)
                .Index(t => t.AssignedUserId);
            
            CreateTable(
                "dbo.IssueCustomFields",
                c => new
                    {
                        FieldName = c.String(nullable: false, maxLength: 128),
                        FieldValue = c.String(),
                        DatabaseFieldName = c.String(),
                        Issue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.FieldName)
                .ForeignKey("dbo.Issues", t => t.Issue_Id)
                .Index(t => t.Issue_Id);
            
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
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Key = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image_ProjectId = c.Int(nullable: false),
                        Image_ImageContent = c.Binary(),
                        Image_ImageFileName = c.String(),
                        Image_ImageFileLength = c.Long(nullable: false),
                        Image_ImageContentType = c.String(),
                        AllowIssueVoting = c.Boolean(nullable: false),
                        Code = c.String(),
                        ManagerId = c.Guid(nullable: false),
                        CreatorUserName = c.String(),
                        CreatorDisplayName = c.String(),
                        Disabled = c.Boolean(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        ManagerUserName = c.String(),
                        ManagerDisplayName = c.String(),
                        UploadPath = c.String(),
                        AllowAttachments = c.Boolean(nullable: false),
                        SvnRepositoryUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Name = c.String(),
                        IsClosedState = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IssueCustomFields", "Issue_Id", "dbo.Issues");
            DropForeignKey("dbo.Issues", "AssignedUserId", "dbo.ITUsers");
            DropForeignKey("dbo.IssueComments", "CreatorUserId", "dbo.ITUsers");
            DropIndex("dbo.IssueCustomFields", new[] { "Issue_Id" });
            DropIndex("dbo.Issues", new[] { "AssignedUserId" });
            DropIndex("dbo.IssueComments", new[] { "CreatorUserId" });
            DropTable("dbo.ProjectStatus");
            DropTable("dbo.Projects");
            DropTable("dbo.Permissions");
            DropTable("dbo.IssueWorkReports");
            DropTable("dbo.IssueVotes");
            DropTable("dbo.IssueCustomFields");
            DropTable("dbo.Issues");
            DropTable("dbo.IssueRevisions");
            DropTable("dbo.IssueNotifications");
            DropTable("dbo.IssueHistories");
            DropTable("dbo.ITUsers");
            DropTable("dbo.IssueComments");
            DropTable("dbo.IssueAttachments");
            DropTable("dbo.HostSettings");
            DropTable("dbo.DefaultValues");
            DropTable("dbo.ApplicationLogs");
        }
    }
}
