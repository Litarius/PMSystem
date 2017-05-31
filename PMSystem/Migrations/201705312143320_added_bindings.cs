namespace PMSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_bindings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectId = c.Int(nullable: false),
                        ChildCount = c.Int(nullable: false),
                        ParentCategoryId = c.Int(nullable: false),
                        IssueCount = c.Int(nullable: false),
                        Disabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.CustomFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Name = c.String(),
                        Required = c.Boolean(nullable: false),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.IssueTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SortOrder = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Milestones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Name = c.String(),
                        SortOrder = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Notes = c.String(),
                        DueDate = c.DateTime(),
                        ReleaseDate = c.DateTime(),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        SortOrder = c.Int(nullable: false),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            AddColumn("dbo.DefaultValues", "Project_Id", c => c.Int());
            AddColumn("dbo.Projects", "ProjectImage_ProjectId", c => c.Int(nullable: false));
            AddColumn("dbo.Projects", "ProjectImage_ImageContent", c => c.Binary());
            AddColumn("dbo.Projects", "ProjectImage_ImageFileName", c => c.String());
            AddColumn("dbo.Projects", "ProjectImage_ImageFileLength", c => c.Long(nullable: false));
            AddColumn("dbo.Projects", "ProjectImage_ImageContentType", c => c.String());
            CreateIndex("dbo.DefaultValues", "Project_Id");
            CreateIndex("dbo.Issues", "ProjectId");
            AddForeignKey("dbo.DefaultValues", "Project_Id", "dbo.Projects", "Id");
            AddForeignKey("dbo.Issues", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Priorities", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Milestones", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.IssueTypes", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Issues", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.DefaultValues", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.CustomFields", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Categories", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Priorities", new[] { "ProjectId" });
            DropIndex("dbo.Milestones", new[] { "ProjectId" });
            DropIndex("dbo.IssueTypes", new[] { "ProjectId" });
            DropIndex("dbo.CustomFields", new[] { "ProjectId" });
            DropIndex("dbo.Categories", new[] { "ProjectId" });
            DropIndex("dbo.Issues", new[] { "ProjectId" });
            DropIndex("dbo.DefaultValues", new[] { "Project_Id" });
            DropColumn("dbo.Projects", "ProjectImage_ImageContentType");
            DropColumn("dbo.Projects", "ProjectImage_ImageFileLength");
            DropColumn("dbo.Projects", "ProjectImage_ImageFileName");
            DropColumn("dbo.Projects", "ProjectImage_ImageContent");
            DropColumn("dbo.Projects", "ProjectImage_ProjectId");
            DropColumn("dbo.DefaultValues", "Project_Id");
            DropTable("dbo.Priorities");
            DropTable("dbo.Milestones");
            DropTable("dbo.IssueTypes");
            DropTable("dbo.CustomFields");
            DropTable("dbo.Categories");
        }
    }
}
