namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrimaryKeys4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Related_MaturityLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropForeignKey("dbo.Related_MaturityLevels", "RelatedMaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.Related_MaturityLevels", new[] { "MaturityLevelId" });
            DropIndex("dbo.Related_MaturityLevels", new[] { "RelatedMaturityLevelId" });
            CreateTable(
                "dbo.RelatedMatLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaturityLevelId = c.Int(nullable: false),
                        RelatedMaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId, cascadeDelete: true)
                .Index(t => t.MaturityLevelId);
            
            DropTable("dbo.Related_MaturityLevels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Related_MaturityLevels",
                c => new
                    {
                        MaturityLevelId = c.Int(nullable: false),
                        RelatedMaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaturityLevelId, t.RelatedMaturityLevelId });
            
            DropForeignKey("dbo.RelatedMatLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.RelatedMatLevels", new[] { "MaturityLevelId" });
            DropTable("dbo.RelatedMatLevels");
            CreateIndex("dbo.Related_MaturityLevels", "RelatedMaturityLevelId");
            CreateIndex("dbo.Related_MaturityLevels", "MaturityLevelId");
            AddForeignKey("dbo.Related_MaturityLevels", "RelatedMaturityLevelId", "dbo.MaturityLevels", "MaturityLevelId");
            AddForeignKey("dbo.Related_MaturityLevels", "MaturityLevelId", "dbo.MaturityLevels", "MaturityLevelId");
        }
    }
}
