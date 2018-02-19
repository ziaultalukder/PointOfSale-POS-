namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenseCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryCode = c.Int(nullable: false),
                        categoryDescription = c.String(),
                        CategoryType = c.String(),
                        Parentid = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExpenseCategories");
        }
    }
}
