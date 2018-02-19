namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenceModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmmount = c.Decimal(nullable: true, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: true, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: true),
                        OutletId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.ItemSetups", t => t.ItemId, cascadeDelete: false)
                .ForeignKey("dbo.Outlates", t => t.OutletId, cascadeDelete: false)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expences", "OutletId", "dbo.Outlates");
            DropForeignKey("dbo.Expences", "ItemId", "dbo.ItemSetups");
            DropForeignKey("dbo.Expences", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Expences", new[] { "ItemId" });
            DropIndex("dbo.Expences", new[] { "EmployeeId" });
            DropIndex("dbo.Expences", new[] { "OutletId" });
            DropTable("dbo.Expences");
        }
    }
}
