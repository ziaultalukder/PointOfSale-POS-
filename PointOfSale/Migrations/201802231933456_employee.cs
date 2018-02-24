namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "OutlateId", "dbo.Outlates");
            DropIndex("dbo.Employees", new[] { "OutlateId" });
            AddColumn("dbo.Employees", "Refarence", c => c.String());
            AddColumn("dbo.Employees", "Delete", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Employees", "OutlateId", c => c.Int());
            CreateIndex("dbo.Employees", "OutlateId");
            AddForeignKey("dbo.Employees", "OutlateId", "dbo.Outlates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "OutlateId", "dbo.Outlates");
            DropIndex("dbo.Employees", new[] { "OutlateId" });
            AlterColumn("dbo.Employees", "OutlateId", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Delete");
            DropColumn("dbo.Employees", "Refarence");
            CreateIndex("dbo.Employees", "OutlateId");
            AddForeignKey("dbo.Employees", "OutlateId", "dbo.Outlates", "Id", cascadeDelete: true);
        }
    }
}
