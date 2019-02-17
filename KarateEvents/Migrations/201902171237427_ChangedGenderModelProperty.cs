namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedGenderModelProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genders", "GenderName", c => c.String());
            DropColumn("dbo.Genders", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genders", "Name", c => c.String());
            DropColumn("dbo.Genders", "GenderName");
        }
    }
}
