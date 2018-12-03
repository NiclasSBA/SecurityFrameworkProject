namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac9 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SecurityPracticeRelatedGdprArticles", newName: "SecurityPracticeGdprArticles");
            RenameColumn(table: "dbo.SecurityPracticeGdprArticles", name: "RelatedGdprArticle_Id", newName: "GdprArticle_ArticleId");
            RenameIndex(table: "dbo.SecurityPracticeGdprArticles", name: "IX_RelatedGdprArticle_Id", newName: "IX_GdprArticle_ArticleId");
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RelatedGdprArticles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        SecurityPracticeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            RenameIndex(table: "dbo.SecurityPracticeGdprArticles", name: "IX_GdprArticle_ArticleId", newName: "IX_RelatedGdprArticle_Id");
            RenameColumn(table: "dbo.SecurityPracticeGdprArticles", name: "GdprArticle_ArticleId", newName: "RelatedGdprArticle_Id");
            RenameTable(name: "dbo.SecurityPracticeGdprArticles", newName: "SecurityPracticeRelatedGdprArticles");
        }
    }
}
