namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartySetupModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PartySetups", "Customer", c => c.String());
            AddColumn("dbo.PartySetups", "Supplier", c => c.String());
            DropColumn("dbo.PartySetups", "PartyType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PartySetups", "PartyType", c => c.String());
            DropColumn("dbo.PartySetups", "Supplier");
            DropColumn("dbo.PartySetups", "Customer");
        }
    }
}
