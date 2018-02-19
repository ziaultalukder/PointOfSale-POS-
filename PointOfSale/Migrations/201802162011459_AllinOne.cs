namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllinOne : DbMigration
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
                        OutlateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Outlates", t => t.OutlateId, cascadeDelete: true)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemSetups", "CatagoryId", "dbo.SetupItemCatagories");
            DropForeignKey("dbo.ExpenseItems", "ExpenseCategory_Id", "dbo.ExpenseCategories");
            DropForeignKey("dbo.Outlates", "OrganaizationId", "dbo.Organaizations");
            DropForeignKey("dbo.Employees", "OutlateId", "dbo.Outlates");
            DropIndex("dbo.ItemSetups", new[] { "CatagoryId" });
            DropIndex("dbo.ExpenseItems", new[] { "ExpenseCategory_Id" });
            DropIndex("dbo.Outlates", new[] { "OrganaizationId" });
            DropIndex("dbo.Employees", new[] { "OutlateId" });
            DropTable("dbo.ItemSetups");
            DropTable("dbo.ExpenseItems");
            DropTable("dbo.Organaizations");
            DropTable("dbo.Outlates");
            DropTable("dbo.Employees");
        }
    }
}
