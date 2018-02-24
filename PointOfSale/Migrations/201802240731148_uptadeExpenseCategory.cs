namespace PointOfSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uptadeExpenseCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseCategoryItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        CategoryCode = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        ExpenseCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ExpenseCategory_Id)
                .Index(t => t.ExpenseCategory_Id);
            
            AddColumn("dbo.ExpenseCategories", "ParentName", c => c.String());
            AddColumn("dbo.ExpenseCategories", "IsDelete", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ExpenseCategories", "CategoryName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenseCategoryItems", "ExpenseCategory_Id", "dbo.ExpenseCategories");
            DropIndex("dbo.ExpenseCategoryItems", new[] { "ExpenseCategory_Id" });
            AlterColumn("dbo.ExpenseCategories", "CategoryName", c => c.String());
            DropColumn("dbo.ExpenseCategories", "IsDelete");
            DropColumn("dbo.ExpenseCategories", "ParentName");
            DropTable("dbo.ExpenseCategoryItems");
        }
    }
}
