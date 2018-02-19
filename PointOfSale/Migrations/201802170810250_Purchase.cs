namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Purchase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remarks = c.String(nullable: false, maxLength: 1000),
                        Date = c.DateTime(nullable: false),
                        OutletId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        PartyTypeId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.ItemSetups", t => t.ItemId, cascadeDelete: false)
                .ForeignKey("dbo.Outlates", t => t.OutletId, cascadeDelete: false)
                .ForeignKey("dbo.PartySetups", t => t.PartyTypeId, cascadeDelete: false)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.PartyTypeId)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "PartyTypeId", "dbo.PartySetups");
            DropForeignKey("dbo.Purchases", "OutletId", "dbo.Outlates");
            DropForeignKey("dbo.Purchases", "ItemId", "dbo.ItemSetups");
            DropForeignKey("dbo.Purchases", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Purchases", new[] { "ItemId" });
            DropIndex("dbo.Purchases", new[] { "PartyTypeId" });
            DropIndex("dbo.Purchases", new[] { "EmployeeId" });
            DropIndex("dbo.Purchases", new[] { "OutletId" });
            DropTable("dbo.Purchases");
        }
    }
}
