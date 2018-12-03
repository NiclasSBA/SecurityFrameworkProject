namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SecurityPracticeRelatedGdprArticles", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices");
            DropForeignKey("dbo.SecurityPracticeRelatedGdprArticles", "RelatedGdprArticle_Id", "dbo.RelatedGdprArticles");
            DropIndex("dbo.SecurityPracticeRelatedGdprArticles", new[] { "SecurityPractice_SecurityPracticeId" });
            DropIndex("dbo.SecurityPracticeRelatedGdprArticles", new[] { "RelatedGdprArticle_Id" });
            CreateIndex("dbo.RelatedGdprArticles", "SecurityPracticeId");
            AddForeignKey("dbo.RelatedGdprArticles", "SecurityPracticeId", "dbo.SecurityPractices", "SecurityPracticeId", cascadeDelete: true);
            DropTable("dbo.SecurityPracticeRelatedGdprArticles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SecurityPracticeRelatedGdprArticles",
                c => new
                    {
                        SecurityPractice_SecurityPracticeId = c.Int(nullable: false),
                        RelatedGdprArticle_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SecurityPractice_SecurityPracticeId, t.RelatedGdprArticle_Id });
            
            DropForeignKey("dbo.RelatedGdprArticles", "SecurityPracticeId", "dbo.SecurityPractices");
            DropIndex("dbo.RelatedGdprArticles", new[] { "SecurityPracticeId" });
            CreateIndex("dbo.SecurityPracticeRelatedGdprArticles", "RelatedGdprArticle_Id");
            CreateIndex("dbo.SecurityPracticeRelatedGdprArticles", "SecurityPractice_SecurityPracticeId");
            AddForeignKey("dbo.SecurityPracticeRelatedGdprArticles", "RelatedGdprArticle_Id", "dbo.RelatedGdprArticles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SecurityPracticeRelatedGdprArticles", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices", "SecurityPracticeId", cascadeDelete: true);
        }
    }
}
