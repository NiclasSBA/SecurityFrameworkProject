namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleaningAndAddedMatLevelStuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaturityLevelGoals",
                c => new
                    {
                        MLevelGoalId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Value = c.String(),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MLevelGoalId)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId, cascadeDelete: true)
                .Index(t => t.MaturityLevelId);
            
            CreateTable(
                "dbo.MaturityLevelQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Value_00 = c.String(),
                        Value_02 = c.String(),
                        Value_05 = c.String(),
                        Value_10 = c.String(),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId, cascadeDelete: true)
                .Index(t => t.MaturityLevelId);
            
            CreateTable(
                "dbo.MaturityLevelCosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId, cascadeDelete: true)
                .Index(t => t.MaturityLevelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaturityLevelCosts", "MaturityLevelId", "dbo.MaturityLevels");
            DropForeignKey("dbo.MaturityLevelQuestions", "MaturityLevelId", "dbo.MaturityLevels");
            DropForeignKey("dbo.MaturityLevelGoals", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.MaturityLevelCosts", new[] { "MaturityLevelId" });
            DropIndex("dbo.MaturityLevelQuestions", new[] { "MaturityLevelId" });
            DropIndex("dbo.MaturityLevelGoals", new[] { "MaturityLevelId" });
            DropTable("dbo.MaturityLevelCosts");
            DropTable("dbo.MaturityLevelQuestions");
            DropTable("dbo.MaturityLevelGoals");
        }
    }
}
