namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpencesItemsModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenceItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 255),
                        Remarks = c.String(nullable: false, maxLength: 555),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expences", t => t.ExpenceId, cascadeDelete: false)
                .Index(t => t.ExpenceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenceItems", "ExpenceId", "dbo.Expences");
            DropIndex("dbo.ExpenceItems", new[] { "ExpenceId" });
            DropTable("dbo.ExpenceItems");
        }
    }
}
