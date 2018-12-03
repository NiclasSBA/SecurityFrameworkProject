namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrimaryKeys3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Related_MaturityLevels", name: "RelatedId", newName: "RelatedMaturityLevelId");
            RenameIndex(table: "dbo.Related_MaturityLevels", name: "IX_RelatedId", newName: "IX_RelatedMaturityLevelId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Related_MaturityLevels", name: "IX_RelatedMaturityLevelId", newName: "IX_RelatedId");
            RenameColumn(table: "dbo.Related_MaturityLevels", name: "RelatedMaturityLevelId", newName: "RelatedId");
        }
    }
}
