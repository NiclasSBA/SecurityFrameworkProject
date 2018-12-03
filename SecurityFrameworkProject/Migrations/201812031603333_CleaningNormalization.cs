namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleaningNormalization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScoreCards",
                c => new
                    {
                        ScoreCardId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        BeforeValue = c.Double(nullable: false),
                        AfterValue = c.Double(nullable: false),
                        ProjectPhaseId = c.Int(nullable: false),
                        SecurityPracticeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScoreCardId)
                .ForeignKey("dbo.ProjectPhases", t => t.ProjectPhaseId, cascadeDelete: true)
                .ForeignKey("dbo.SecurityPractices", t => t.SecurityPracticeId, cascadeDelete: true)
                .Index(t => t.ProjectPhaseId)
                .Index(t => t.SecurityPracticeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScoreCards", "SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.ScoreCards", "ProjectPhaseId", "dbo.ProjectPhases");
            DropIndex("dbo.ScoreCards", new[] { "SecurityPracticeId" });
            DropIndex("dbo.ScoreCards", new[] { "ProjectPhaseId" });
            DropTable("dbo.ScoreCards");
        }
    }
}
