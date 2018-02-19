namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Purchases", t => t.PurchaseId, cascadeDelete: false)
                .Index(t => t.PurchaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseItems", "PurchaseId", "dbo.Purchases");
            DropIndex("dbo.PurchaseItems", new[] { "PurchaseId" });
            DropTable("dbo.PurchaseItems");
        }
    }
}
