namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDateCreatedAndUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clubs", "DateCreated", c => c.DateTime());
            AddColumn("dbo.Clubs", "DateUpdated", c => c.DateTime());
            AddColumn("dbo.Coaches", "DateCreated", c => c.DateTime());
            AddColumn("dbo.Coaches", "DateUpdated", c => c.DateTime());
            AddColumn("dbo.Competitors", "DateCreated", c => c.DateTime());
            AddColumn("dbo.Competitors", "DateUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Competitors", "DateUpdated");
            DropColumn("dbo.Competitors", "DateCreated");
            DropColumn("dbo.Coaches", "DateUpdated");
            DropColumn("dbo.Coaches", "DateCreated");
            DropColumn("dbo.Clubs", "DateUpdated");
            DropColumn("dbo.Clubs", "DateCreated");
        }
    }
}
