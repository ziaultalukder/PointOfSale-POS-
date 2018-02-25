namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemsetup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemSetups", "IsDeleteMode", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemSetups", "IsDeleteMode");
        }
    }
}
