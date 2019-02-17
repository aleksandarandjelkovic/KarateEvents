namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCoachModelValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coaches", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Coaches", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coaches", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coaches", "Name", c => c.String(nullable: false));
        }
    }
}
