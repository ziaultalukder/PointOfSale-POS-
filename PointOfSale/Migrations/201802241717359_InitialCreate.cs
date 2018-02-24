namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Contact = c.String(),
                        Email = c.String(),
                        JoinintDate = c.DateTime(nullable: false),
                        EmergencyNumber = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Nid = c.String(),
                        PresentAddress = c.String(),
                        PermanentAddress = c.String(),
                        Image = c.Binary(),
                        Refarence = c.String(),
                        OutlateId = c.Int(),
                        Delete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Outlates", t => t.OutlateId)
                .Index(t => t.OutlateId);
            
            CreateTable(
                "dbo.Outlates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Contact = c.String(),
                        Address = c.String(),
                        OrganaizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organaizations", t => t.OrganaizationId, cascadeDelete: true)
                .Index(t => t.OrganaizationId);
            
            CreateTable(
                "dbo.Organaizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 155),
                        Code = c.String(maxLength: 155),
                        Contact = c.String(maxLength: 20),
                        Description = c.String(maxLength: 555),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenceItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 255),
                        Remarks = c.String(nullable: false, maxLength: 555),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expences", t => t.ExpenceId, cascadeDelete: true)
                .Index(t => t.ExpenceId);
            
            CreateTable(
                "dbo.Expences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenceDate = c.DateTime(nullable: false),
                        OutletId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.ItemSetups", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Outlates", t => t.OutletId, cascadeDelete: true)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ItemSetups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CostPrice = c.Double(nullable: false),
                        SalesPrice = c.Double(nullable: false),
                        Code = c.String(),
                        Description = c.String(),
                        Image = c.Binary(),
                        CatagoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SetupItemCatagories", t => t.CatagoryId, cascadeDelete: true)
                .Index(t => t.CatagoryId);
            
            CreateTable(
                "dbo.SetupItemCatagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Code = c.String(maxLength: 255),
                        Description = c.String(maxLength: 255),
                        CatagoryType = c.String(maxLength: 55),
                        Image = c.Binary(),
                        CatagoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SetupItemCatagories", t => t.CatagoryId)
                .Index(t => t.CatagoryId);
            
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        CategoryCode = c.Int(nullable: false),
                        CategoryDescription = c.String(),
                        CategoryType = c.String(),
                        Parentid = c.Int(),
                        ParentName = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseCategoryItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        CategoryCode = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        ExpenseCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ExpenseCategory_Id)
                .Index(t => t.ExpenseCategory_Id);
            
            CreateTable(
                "dbo.ExpenseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        CategoryCode = c.Int(nullable: false),
                        ExpenseCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ExpenseCategory_Id)
                .Index(t => t.ExpenseCategory_Id);
            
            CreateTable(
                "dbo.PartySetups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Code = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Image = c.Binary(),
                        DataTime = c.DateTime(nullable: false),
                        Customer = c.String(),
                        Supplier = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .ForeignKey("dbo.Purchases", t => t.PurchaseId, cascadeDelete: true)
                .Index(t => t.PurchaseId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remarks = c.String(nullable: false, maxLength: 1000),
                        PurchaseDate = c.DateTime(nullable: false),
                        SalesNumber = c.String(nullable: false, maxLength: 255),
                        OutletId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        PartyTypeId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.ItemSetups", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Outlates", t => t.OutletId, cascadeDelete: true)
                .ForeignKey("dbo.PartySetups", t => t.PartyTypeId, cascadeDelete: true)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.PartyTypeId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesNumber = c.String(),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesDate = c.DateTime(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OutletId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartySetups", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Outlates", t => t.OutletId, cascadeDelete: true)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.SalesItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 255),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sales", t => t.SalesId, cascadeDelete: true)
                .Index(t => t.SalesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesItems", "SalesId", "dbo.Sales");
            DropForeignKey("dbo.Sales", "OutletId", "dbo.Outlates");
            DropForeignKey("dbo.Sales", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.PartySetups");
            DropForeignKey("dbo.PurchaseItems", "PurchaseId", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "PartyTypeId", "dbo.PartySetups");
            DropForeignKey("dbo.Purchases", "OutletId", "dbo.Outlates");
            DropForeignKey("dbo.Purchases", "ItemId", "dbo.ItemSetups");
            DropForeignKey("dbo.Purchases", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ExpenseItems", "ExpenseCategory_Id", "dbo.ExpenseCategories");
            DropForeignKey("dbo.ExpenseCategoryItems", "ExpenseCategory_Id", "dbo.ExpenseCategories");
            DropForeignKey("dbo.Expences", "OutletId", "dbo.Outlates");
            DropForeignKey("dbo.Expences", "ItemId", "dbo.ItemSetups");
            DropForeignKey("dbo.ItemSetups", "CatagoryId", "dbo.SetupItemCatagories");
            DropForeignKey("dbo.SetupItemCatagories", "CatagoryId", "dbo.SetupItemCatagories");
            DropForeignKey("dbo.ExpenceItems", "ExpenceId", "dbo.Expences");
            DropForeignKey("dbo.Expences", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Outlates", "OrganaizationId", "dbo.Organaizations");
            DropForeignKey("dbo.Employees", "OutlateId", "dbo.Outlates");
            DropIndex("dbo.SalesItems", new[] { "SalesId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "EmployeeId" });
            DropIndex("dbo.Sales", new[] { "OutletId" });
            DropIndex("dbo.Purchases", new[] { "ItemId" });
            DropIndex("dbo.Purchases", new[] { "PartyTypeId" });
            DropIndex("dbo.Purchases", new[] { "EmployeeId" });
            DropIndex("dbo.Purchases", new[] { "OutletId" });
            DropIndex("dbo.PurchaseItems", new[] { "PurchaseId" });
            DropIndex("dbo.ExpenseItems", new[] { "ExpenseCategory_Id" });
            DropIndex("dbo.ExpenseCategoryItems", new[] { "ExpenseCategory_Id" });
            DropIndex("dbo.SetupItemCatagories", new[] { "CatagoryId" });
            DropIndex("dbo.ItemSetups", new[] { "CatagoryId" });
            DropIndex("dbo.Expences", new[] { "ItemId" });
            DropIndex("dbo.Expences", new[] { "EmployeeId" });
            DropIndex("dbo.Expences", new[] { "OutletId" });
            DropIndex("dbo.ExpenceItems", new[] { "ExpenceId" });
            DropIndex("dbo.Outlates", new[] { "OrganaizationId" });
            DropIndex("dbo.Employees", new[] { "OutlateId" });
            DropTable("dbo.SalesItems");
            DropTable("dbo.Sales");
            DropTable("dbo.Purchases");
            DropTable("dbo.PurchaseItems");
            DropTable("dbo.PartySetups");
            DropTable("dbo.ExpenseItems");
            DropTable("dbo.ExpenseCategoryItems");
            DropTable("dbo.ExpenseCategories");
            DropTable("dbo.SetupItemCatagories");
            DropTable("dbo.ItemSetups");
            DropTable("dbo.Expences");
            DropTable("dbo.ExpenceItems");
            DropTable("dbo.Organaizations");
            DropTable("dbo.Outlates");
            DropTable("dbo.Employees");
        }
    }
}
