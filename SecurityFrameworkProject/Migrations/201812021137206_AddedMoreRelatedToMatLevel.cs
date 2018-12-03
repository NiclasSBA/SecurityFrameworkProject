namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreRelatedToMatLevel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ActivitiesMaturityLevels", newName: "MaturityLevelActivities");
            CreateTable(
                "dbo.GdprArticles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        ArticleNumber = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GdprArticles");
            RenameTable(name: "dbo.MaturityLevelActivities", newName: "ActivitiesMaturityLevels");
        }
    }
}
