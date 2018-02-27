namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setupitemcatagory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SetupItemCatagories", "IsDeleteMode", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SetupItemCatagories", "IsDeleteMode");
        }
    }
}
