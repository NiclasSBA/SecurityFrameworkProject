namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrimaryKeys2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RelatedMatLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.RelatedMatLevels", new[] { "MaturityLevelId" });
            CreateTable(
                "dbo.Related_MaturityLevels",
                c => new
                    {
                        MaturityLevelId = c.Int(nullable: false),
                        RelatedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaturityLevelId, t.RelatedId })
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId)
                .ForeignKey("dbo.MaturityLevels", t => t.RelatedId)
                .Index(t => t.MaturityLevelId)
                .Index(t => t.RelatedId);
            
            DropTable("dbo.RelatedMatLevels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RelatedMatLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Related_MaturityLevels", "RelatedId", "dbo.MaturityLevels");
            DropForeignKey("dbo.Related_MaturityLevels", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.Related_MaturityLevels", new[] { "RelatedId" });
            DropIndex("dbo.Related_MaturityLevels", new[] { "MaturityLevelId" });
            DropTable("dbo.Related_MaturityLevels");
            CreateIndex("dbo.RelatedMatLevels", "MaturityLevelId");
            AddForeignKey("dbo.RelatedMatLevels", "MaturityLevelId", "dbo.MaturityLevels", "MaturityLevelId");
        }
    }
}
