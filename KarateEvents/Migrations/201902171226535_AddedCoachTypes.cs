namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCoachTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoachTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoachTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoachTypes");
        }
    }
}
