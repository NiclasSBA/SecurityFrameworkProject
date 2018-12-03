namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RelatedGdprArticles", "ArticleId", "dbo.GdprArticles");
            DropForeignKey("dbo.RelatedGdprArticles", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices");
            DropIndex("dbo.RelatedGdprArticles", new[] { "ArticleId" });
            DropIndex("dbo.RelatedGdprArticles", new[] { "SecurityPractice_SecurityPracticeId" });
            DropColumn("dbo.RelatedGdprArticles", "SecurityPractice_SecurityPracticeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RelatedGdprArticles", "SecurityPractice_SecurityPracticeId", c => c.Int());
            CreateIndex("dbo.RelatedGdprArticles", "SecurityPractice_SecurityPracticeId");
            CreateIndex("dbo.RelatedGdprArticles", "ArticleId");
            AddForeignKey("dbo.RelatedGdprArticles", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices", "SecurityPracticeId");
            AddForeignKey("dbo.RelatedGdprArticles", "ArticleId", "dbo.GdprArticles", "ArticleId", cascadeDelete: true);
        }
    }
}
