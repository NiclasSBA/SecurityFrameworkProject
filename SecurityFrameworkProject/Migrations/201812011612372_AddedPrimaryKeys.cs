namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrimaryKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RelatedMaturityLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropForeignKey("dbo.RelatedMaturityLevels", "RelatedMaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.RelatedMaturityLevels", new[] { "MaturityLevelId" });
            DropIndex("dbo.RelatedMaturityLevels", new[] { "RelatedMaturityLevelId" });
            CreateTable(
                "dbo.RelatedMatLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId)
                .Index(t => t.MaturityLevelId);
            
         
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RelatedMaturityLevels",
                c => new
                    {
                        MaturityLevelId = c.Int(nullable: false),
                        RelatedMaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaturityLevelId, t.RelatedMaturityLevelId });
            
            DropForeignKey("dbo.RelatedMatLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.RelatedMatLevels", new[] { "MaturityLevelId" });
            DropTable("dbo.RelatedMatLevels");
            CreateIndex("dbo.RelatedMaturityLevels", "RelatedMaturityLevelId");
            CreateIndex("dbo.RelatedMaturityLevels", "MaturityLevelId");
            AddForeignKey("dbo.RelatedMaturityLevels", "RelatedMaturityLevelId", "dbo.MaturityLevels", "MaturityLevelId");
            AddForeignKey("dbo.RelatedMaturityLevels", "MaturityLevelId", "dbo.MaturityLevels", "MaturityLevelId");
        }
    }
}
