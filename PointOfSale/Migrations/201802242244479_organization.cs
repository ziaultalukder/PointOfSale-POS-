namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class organization : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organaizations", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Organaizations", "IsDelete");
        }
    }
}
