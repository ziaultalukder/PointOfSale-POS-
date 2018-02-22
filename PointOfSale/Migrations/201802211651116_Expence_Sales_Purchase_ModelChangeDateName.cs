namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expence_Sales_Purchase_ModelChangeDateName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expences", "ExpenceDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Purchases", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sales", "SalesDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Expences", "Date");
            DropColumn("dbo.Purchases", "Date");
            DropColumn("dbo.Sales", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Purchases", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Expences", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "SalesDate");
            DropColumn("dbo.Purchases", "PurchaseDate");
            DropColumn("dbo.Expences", "ExpenceDate");
        }
    }
}
