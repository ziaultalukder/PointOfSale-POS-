namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expenceItemModelChane : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExpenceItems", "LineTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpenceItems", "LineTotal");
        }
    }
}
