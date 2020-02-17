namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedCoachEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coaches", "CoachType_Id", c => c.Int());
            AddColumn("dbo.Coaches", "Gender_Id", c => c.Int());
            CreateIndex("dbo.Coaches", "CoachType_Id");
            CreateIndex("dbo.Coaches", "Gender_Id");
            AddForeignKey("dbo.Coaches", "CoachType_Id", "dbo.CoachTypes", "Id");
            AddForeignKey("dbo.Coaches", "Gender_Id", "dbo.Genders", "Id");
            DropColumn("dbo.Coaches", "GenderId");
            DropColumn("dbo.Coaches", "CoachTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coaches", "CoachTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Coaches", "GenderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Coaches", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Coaches", "CoachType_Id", "dbo.CoachTypes");
            DropIndex("dbo.Coaches", new[] { "Gender_Id" });
            DropIndex("dbo.Coaches", new[] { "CoachType_Id" });
            DropColumn("dbo.Coaches", "Gender_Id");
            DropColumn("dbo.Coaches", "CoachType_Id");
        }
    }
}
