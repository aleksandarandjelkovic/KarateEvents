namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoachModelRemovedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coaches", "Name", c => c.String());
            AlterColumn("dbo.Coaches", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coaches", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Coaches", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
