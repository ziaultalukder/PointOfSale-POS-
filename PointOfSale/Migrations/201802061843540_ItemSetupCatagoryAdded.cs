namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemSetupCatagoryAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SetupItemCatagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Code = c.String(maxLength: 255),
                        Description = c.String(maxLength: 255),
                        CatagoryType = c.String(maxLength: 55),
                        Image = c.Binary(),
                        CatagoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SetupItemCatagories", t => t.CatagoryId)
                .Index(t => t.CatagoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SetupItemCatagories", "CatagoryId", "dbo.SetupItemCatagories");
            DropIndex("dbo.SetupItemCatagories", new[] { "CatagoryId" });
            DropTable("dbo.SetupItemCatagories");
        }
    }
}
