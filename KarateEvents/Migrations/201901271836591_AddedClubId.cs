namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClubId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Competitors", "ClubId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Competitors", "ClubId");
        }
    }
}
