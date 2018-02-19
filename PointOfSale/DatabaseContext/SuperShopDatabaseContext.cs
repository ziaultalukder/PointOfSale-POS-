using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;

namespace PointOfSale.DatabaseContext
{
    class SuperShopDatabaseContext:DbContext
    {
        public DbSet<PartySetup> PartySetup { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public DbSet<SetupItemCatagory> SetupItemCatagories { get; set; } 
        public DbSet<ItemSetups> ItemSetups { get; set; }
        public DbSet<Organaization> Organaization { get; set; }
        public DbSet<Outlate> Outlates { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<ExpenseItem> ExpenseItem { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Expence> Expences { get; set; }
        public DbSet<ExpenceItems> ExpenceItems { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesItem> SalesItem { get; set; }
        

    }
}
