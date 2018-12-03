namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMatLevelActivities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivitiesMaturityLevels",
                c => new
                    {
                        ActivitiesMaturityLevelId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActivitiesMaturityLevelId)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId, cascadeDelete: true)
                .Index(t => t.MaturityLevelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActivitiesMaturityLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.ActivitiesMaturityLevels", new[] { "MaturityLevelId" });
            DropTable("dbo.ActivitiesMaturityLevels");
        }
    }
}
