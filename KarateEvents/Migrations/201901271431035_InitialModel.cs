namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Owner = c.String(nullable: false, maxLength: 50),
                        Pib = c.String(nullable: false, maxLength: 8),
                        Address = c.String(nullable: false, maxLength: 100),
                        City = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        DateOfBirth = c.DateTime(nullable: false),
                        Age = c.String(),
                        Category = c.String(),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Competitors");
            DropTable("dbo.Clubs");
        }
    }
}
