namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoriesUnion : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CadetCategories", newName: "Categories");
            DropTable("dbo.JuniorCategories");
            DropTable("dbo.SeniorCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SeniorCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JuniorCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            RenameTable(name: "dbo.Categories", newName: "CadetCategories");
        }
    }
}
