namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleaningAndRElations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GdprArticleItems",
                c => new
                    {
                        ArticleItemId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        GdprArticle_ArticleId = c.Int(),
                    })
                .PrimaryKey(t => t.ArticleItemId)
                .ForeignKey("dbo.GdprArticles", t => t.GdprArticle_ArticleId)
                .Index(t => t.GdprArticle_ArticleId);
            
            CreateTable(
                "dbo.GdprSuitableRecitals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RecitalNumber = c.Int(nullable: false),
                        Description = c.String(),
                        GdprArticle_ArticleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GdprArticles", t => t.GdprArticle_ArticleId)
                .Index(t => t.GdprArticle_ArticleId);
            
            AddColumn("dbo.GdprArticles", "Title", c => c.String());
            DropColumn("dbo.GdprArticles", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GdprArticles", "Description", c => c.String());
            DropForeignKey("dbo.GdprSuitableRecitals", "GdprArticle_ArticleId", "dbo.GdprArticles");
            DropForeignKey("dbo.GdprArticleItems", "GdprArticle_ArticleId", "dbo.GdprArticles");
            DropIndex("dbo.GdprSuitableRecitals", new[] { "GdprArticle_ArticleId" });
            DropIndex("dbo.GdprArticleItems", new[] { "GdprArticle_ArticleId" });
            DropColumn("dbo.GdprArticles", "Title");
            DropTable("dbo.GdprSuitableRecitals");
            DropTable("dbo.GdprArticleItems");
        }
    }
}
