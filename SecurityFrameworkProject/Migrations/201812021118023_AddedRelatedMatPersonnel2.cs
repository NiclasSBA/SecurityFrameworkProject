namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelatedMatPersonnel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaturityLevelPersonnels", "PersonnelId", c => c.Int(nullable: false));
            CreateIndex("dbo.MaturityLevelPersonnels", "PersonnelId");
            AddForeignKey("dbo.MaturityLevelPersonnels", "PersonnelId", "dbo.Personnels", "PersonnelId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaturityLevelPersonnels", "PersonnelId", "dbo.Personnels");
            DropIndex("dbo.MaturityLevelPersonnels", new[] { "PersonnelId" });
            DropColumn("dbo.MaturityLevelPersonnels", "PersonnelId");
        }
    }
}
