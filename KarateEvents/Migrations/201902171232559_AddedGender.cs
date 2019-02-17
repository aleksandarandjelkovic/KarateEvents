namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGender : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Coaches", "GenderId", c => c.Int(nullable: false));
            AddColumn("dbo.Competitors", "GenderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Coaches", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Coaches", "Gender");
            DropColumn("dbo.Competitors", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Competitors", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.Coaches", "Gender", c => c.String());
            AlterColumn("dbo.Coaches", "Name", c => c.String());
            DropColumn("dbo.Competitors", "GenderId");
            DropColumn("dbo.Coaches", "GenderId");
            DropTable("dbo.Genders");
        }
    }
}
