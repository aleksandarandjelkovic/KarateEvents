namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClubModelRemovedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clubs", "Name", c => c.String());
            AlterColumn("dbo.Clubs", "Owner", c => c.String());
            AlterColumn("dbo.Clubs", "Pib", c => c.String());
            AlterColumn("dbo.Clubs", "Address", c => c.String());
            AlterColumn("dbo.Clubs", "City", c => c.String());
            AlterColumn("dbo.Clubs", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clubs", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clubs", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clubs", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clubs", "Pib", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Clubs", "Owner", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clubs", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
