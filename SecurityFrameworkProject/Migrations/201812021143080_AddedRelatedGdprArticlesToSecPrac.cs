namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RelatedGdprArticles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        SecurityPracticeId = c.Int(nullable: false),
                        SecurityPractice_SecurityPracticeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GdprArticles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.SecurityPractices", t => t.SecurityPractice_SecurityPracticeId)
                .ForeignKey("dbo.SecurityPractices", t => t.SecurityPracticeId, cascadeDelete: true)
                .Index(t => t.ArticleId)
                .Index(t => t.SecurityPracticeId)
                .Index(t => t.SecurityPractice_SecurityPracticeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RelatedGdprArticles", "SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.RelatedGdprArticles", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.RelatedGdprArticles", "ArticleId", "dbo.GdprArticles");
            DropIndex("dbo.RelatedGdprArticles", new[] { "SecurityPractice_SecurityPracticeId" });
            DropIndex("dbo.RelatedGdprArticles", new[] { "SecurityPracticeId" });
            DropIndex("dbo.RelatedGdprArticles", new[] { "ArticleId" });
            DropTable("dbo.RelatedGdprArticles");
        }
    }
}
