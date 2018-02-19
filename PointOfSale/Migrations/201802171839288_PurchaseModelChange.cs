namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "SalesNumber", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "SalesNumber");
        }
    }
}
