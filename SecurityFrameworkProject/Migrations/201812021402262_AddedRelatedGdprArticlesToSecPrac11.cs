namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SecurityPractices", "GdprArticle_ArticleId", "dbo.GdprArticles");
            DropIndex("dbo.SecurityPractices", new[] { "GdprArticle_ArticleId" });
            CreateTable(
                "dbo.GdprArticleSecurityPractices",
                c => new
                    {
                        GdprArticle_ArticleId = c.Int(nullable: false),
                        SecurityPractice_SecurityPracticeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GdprArticle_ArticleId, t.SecurityPractice_SecurityPracticeId })
                .ForeignKey("dbo.GdprArticles", t => t.GdprArticle_ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.SecurityPractices", t => t.SecurityPractice_SecurityPracticeId, cascadeDelete: true)
                .Index(t => t.GdprArticle_ArticleId)
                .Index(t => t.SecurityPractice_SecurityPracticeId);
            
            DropColumn("dbo.SecurityPractices", "GdprArticle_ArticleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SecurityPractices", "GdprArticle_ArticleId", c => c.Int());
            DropForeignKey("dbo.GdprArticleSecurityPractices", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.GdprArticleSecurityPractices", "GdprArticle_ArticleId", "dbo.GdprArticles");
            DropIndex("dbo.GdprArticleSecurityPractices", new[] { "SecurityPractice_SecurityPracticeId" });
            DropIndex("dbo.GdprArticleSecurityPractices", new[] { "GdprArticle_ArticleId" });
            DropTable("dbo.GdprArticleSecurityPractices");
            CreateIndex("dbo.SecurityPractices", "GdprArticle_ArticleId");
            AddForeignKey("dbo.SecurityPractices", "GdprArticle_ArticleId", "dbo.GdprArticles", "ArticleId");
        }
    }
}
