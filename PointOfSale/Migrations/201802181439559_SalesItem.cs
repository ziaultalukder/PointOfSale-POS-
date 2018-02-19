namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: true, maxLength: 255),
                        Quantity = c.Decimal(nullable: true, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: true, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: true, precision: 18, scale: 2),
                        SalesId = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sales", t => t.SalesId, cascadeDelete: false)
                .Index(t => t.SalesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesItems", "SalesId", "dbo.Sales");
            DropIndex("dbo.SalesItems", new[] { "SalesId" });
            DropTable("dbo.SalesItems");
        }
    }
}
