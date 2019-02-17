namespace KarateEvents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCompetitorCategoryId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Competitors", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Competitors", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Competitors", "Category", c => c.String());
            DropColumn("dbo.Competitors", "CategoryId");
        }
    }
}
