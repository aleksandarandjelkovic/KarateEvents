namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClubToCoachEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coaches", "Club_Id", c => c.Int());
            CreateIndex("dbo.Coaches", "Club_Id");
            AddForeignKey("dbo.Coaches", "Club_Id", "dbo.Clubs", "Id");
            DropColumn("dbo.Coaches", "ClubId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coaches", "ClubId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Coaches", "Club_Id", "dbo.Clubs");
            DropIndex("dbo.Coaches", new[] { "Club_Id" });
            DropColumn("dbo.Coaches", "Club_Id");
        }
    }
}
