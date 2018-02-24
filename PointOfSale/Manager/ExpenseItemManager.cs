using PointOfSale.DatabaseContext;
using PointOfSale.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Manager
{
    class ExpenseItemManager
    {
        private SuperShopDatabaseContext db;

        public bool InsertExpenseCategoryItems(ExpenseCategoryItems expenseItem)
        {
            using (db = new SuperShopDatabaseContext())
            {
                db.ExpenseCategoryItems.Add(expenseItem);
                return db.SaveChanges() > 0;
            }
        }
        public bool UpdateExpenseCategoryItems(ExpenseCategoryItems expenseItem)
        {
            using (db = new SuperShopDatabaseContext())
            {
                db.Entry(expenseItem).State = EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }

        public object DeleteExpenseCategoryItems(ExpenseCategoryItems expenseItem)
        {
            using (db = new SuperShopDatabaseContext())
            {
                db.Entry(expenseItem).State = EntityState.Deleted;
                return db.SaveChanges() > 0;
            }
        }

        //public bool UpdateExpense(ExpenseItem expenseItem)
        //{
        //    SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        //    db.Entry(expenseItem).State = EntityState.Modified;
        //    return db.SaveChanges() > 0;
        //}
    }
}
