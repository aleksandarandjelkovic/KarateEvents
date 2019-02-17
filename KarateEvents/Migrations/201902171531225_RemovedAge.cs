namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAge : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Competitors", "Age");
            DropTable("dbo.Ages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Competitors", "Age", c => c.String());
        }
    }
}
