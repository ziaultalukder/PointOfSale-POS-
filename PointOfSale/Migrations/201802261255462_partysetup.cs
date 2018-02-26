namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partysetup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PartySetups", "IsDeleteMode", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PartySetups", "IsDeleteMode");
        }
    }
}
