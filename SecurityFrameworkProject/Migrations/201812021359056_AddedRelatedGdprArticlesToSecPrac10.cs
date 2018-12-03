namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SecurityPractices", "GdprArticle_ArticleId", c => c.Int());
            CreateIndex("dbo.SecurityPractices", "GdprArticle_ArticleId");
            AddForeignKey("dbo.SecurityPractices", "GdprArticle_ArticleId", "dbo.GdprArticles", "ArticleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SecurityPractices", "GdprArticle_ArticleId", "dbo.GdprArticles");
            DropIndex("dbo.SecurityPractices", new[] { "GdprArticle_ArticleId" });
            DropColumn("dbo.SecurityPractices", "GdprArticle_ArticleId");
        }
    }
}
