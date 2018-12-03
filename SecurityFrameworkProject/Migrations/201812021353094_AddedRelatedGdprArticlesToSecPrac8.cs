namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedGdprArticlesToSecPrac8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RelatedGdprArticles", "SecurityPracticeId", "dbo.SecurityPractices");
            DropIndex("dbo.RelatedGdprArticles", new[] { "SecurityPracticeId" });
            CreateTable(
                "dbo.SecurityPracticeRelatedGdprArticles",
                c => new
                    {
                        SecurityPractice_SecurityPracticeId = c.Int(nullable: false),
                        RelatedGdprArticle_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SecurityPractice_SecurityPracticeId, t.RelatedGdprArticle_Id })
                .ForeignKey("dbo.SecurityPractices", t => t.SecurityPractice_SecurityPracticeId, cascadeDelete: true)
                .ForeignKey("dbo.RelatedGdprArticles", t => t.RelatedGdprArticle_Id, cascadeDelete: true)
                .Index(t => t.SecurityPractice_SecurityPracticeId)
                .Index(t => t.RelatedGdprArticle_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SecurityPracticeRelatedGdprArticles", "RelatedGdprArticle_Id", "dbo.RelatedGdprArticles");
            DropForeignKey("dbo.SecurityPracticeRelatedGdprArticles", "SecurityPractice_SecurityPracticeId", "dbo.SecurityPractices");
            DropIndex("dbo.SecurityPracticeRelatedGdprArticles", new[] { "RelatedGdprArticle_Id" });
            DropIndex("dbo.SecurityPracticeRelatedGdprArticles", new[] { "SecurityPractice_SecurityPracticeId" });
            DropTable("dbo.SecurityPracticeRelatedGdprArticles");
            CreateIndex("dbo.RelatedGdprArticles", "SecurityPracticeId");
            AddForeignKey("dbo.RelatedGdprArticles", "SecurityPracticeId", "dbo.SecurityPractices", "SecurityPracticeId", cascadeDelete: true);
        }
    }
}
