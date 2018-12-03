namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaturityLevels",
                c => new
                    {
                        MaturityLevelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Objective = c.String(),
                        SecurityPracticeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaturityLevelId)
                .ForeignKey("dbo.SecurityPractices", t => t.SecurityPracticeId, cascadeDelete: true)
                .Index(t => t.SecurityPracticeId);
            
            CreateTable(
                "dbo.SecurityPractices",
                c => new
                    {
                        SecurityPracticeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BusinessFunctionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SecurityPracticeId)
                .ForeignKey("dbo.BusinessFunctions", t => t.BusinessFunctionId, cascadeDelete: true)
                .Index(t => t.BusinessFunctionId);
            
            CreateTable(
                "dbo.BusinessFunctions",
                c => new
                    {
                        BusinessFunctionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BusinessFunctionId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        ProjectManagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.ProjectManagers", t => t.ProjectManagerId, cascadeDelete: true)
                .Index(t => t.ProjectManagerId);
            
            CreateTable(
                "dbo.ProjectManagers",
                c => new
                    {
                        ProjectManagerId = c.Int(nullable: false, identity: true),
                        AdminSince = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        PersonnelUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectManagerId)
                .ForeignKey("dbo.PersonnelUsers", t => t.PersonnelUserId, cascadeDelete: true)
                .Index(t => t.PersonnelUserId);
            
            CreateTable(
                "dbo.PersonnelUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonnelId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personnels", t => t.PersonnelId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.PersonnelId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        PersonnelId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        RelationToCompany = c.String(),
                    })
                .PrimaryKey(t => t.PersonnelId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProjectManagerId", "dbo.ProjectManagers");
            DropForeignKey("dbo.ProjectManagers", "PersonnelUserId", "dbo.PersonnelUsers");
            DropForeignKey("dbo.PersonnelUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.PersonnelUsers", "PersonnelId", "dbo.Personnels");
            DropForeignKey("dbo.MaturityLevels", "SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.SecurityPractices", "BusinessFunctionId", "dbo.BusinessFunctions");
            DropIndex("dbo.PersonnelUsers", new[] { "UserId" });
            DropIndex("dbo.PersonnelUsers", new[] { "PersonnelId" });
            DropIndex("dbo.ProjectManagers", new[] { "PersonnelUserId" });
            DropIndex("dbo.Projects", new[] { "ProjectManagerId" });
            DropIndex("dbo.SecurityPractices", new[] { "BusinessFunctionId" });
            DropIndex("dbo.MaturityLevels", new[] { "SecurityPracticeId" });
            DropTable("dbo.Users");
            DropTable("dbo.Personnels");
            DropTable("dbo.PersonnelUsers");
            DropTable("dbo.ProjectManagers");
            DropTable("dbo.Projects");
            DropTable("dbo.BusinessFunctions");
            DropTable("dbo.SecurityPractices");
            DropTable("dbo.MaturityLevels");
        }
    }
}
