namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
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
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaturityLevels", "SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.SecurityPractices", "BusinessFunctionId", "dbo.BusinessFunctions");
            DropIndex("dbo.SecurityPractices", new[] { "BusinessFunctionId" });
            DropIndex("dbo.MaturityLevels", new[] { "SecurityPracticeId" });
            DropTable("dbo.Projects");
            DropTable("dbo.BusinessFunctions");
            DropTable("dbo.SecurityPractices");
            DropTable("dbo.MaturityLevels");
        }
    }
}
