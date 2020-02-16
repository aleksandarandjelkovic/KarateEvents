namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompetitorModelRemovedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Competitors", "Name", c => c.String());
            AlterColumn("dbo.Competitors", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Competitors", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Competitors", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
