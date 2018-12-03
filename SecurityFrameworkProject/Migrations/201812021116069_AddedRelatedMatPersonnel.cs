namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedMatPersonnel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaturityLevelPersonnels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        MaturityLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaturityLevels", t => t.MaturityLevelId, cascadeDelete: true)
                .Index(t => t.MaturityLevelId);
            
            AddColumn("dbo.MaturityLevels", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaturityLevelPersonnels", "MaturityLevelId", "dbo.MaturityLevels");
            DropIndex("dbo.MaturityLevelPersonnels", new[] { "MaturityLevelId" });
            DropColumn("dbo.MaturityLevels", "Level");
            DropTable("dbo.MaturityLevelPersonnels");
        }
    }
}
