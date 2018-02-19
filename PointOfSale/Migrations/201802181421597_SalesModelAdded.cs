namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmount = c.Decimal(nullable: true, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: true, precision: 18, scale: 2),
                        SalesNumber = c.String(),
                        Vat = c.Decimal(nullable: true, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: true, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: true),
                        OutletId = c.Int(nullable: true),
                        EmployeeId = c.Int(nullable: true),
                        CustomerId = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartySetups", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Outlates", t => t.OutletId, cascadeDelete: false)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "OutletId", "dbo.Outlates");
            DropForeignKey("dbo.Sales", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.PartySetups");
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "EmployeeId" });
            DropIndex("dbo.Sales", new[] { "OutletId" });
            DropTable("dbo.Sales");
        }
    }
}
