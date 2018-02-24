namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesModel_Subtotal_Field_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "Subtotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "Subtotal");
        }
    }
}
