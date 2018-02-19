namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartySetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartySetups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Code = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Image = c.Binary(),
                        DataTime = c.DateTime(nullable: false),
                        PartyType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PartySetups");
        }
    }
}
