namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Purchases", "ItemId", "dbo.ItemSetups");
            DropIndex("dbo.Purchases", new[] { "ItemId" });
            DropColumn("dbo.Purchases", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Purchases", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Purchases", "ItemId");
            AddForeignKey("dbo.Purchases", "ItemId", "dbo.ItemSetups", "Id", cascadeDelete: true);
        }
    }
}
