namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompetitorDateTypeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Competitors", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Competitors", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
