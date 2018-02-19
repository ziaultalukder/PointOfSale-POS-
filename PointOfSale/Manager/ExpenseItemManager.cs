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
        public bool InsertExpenseItem(ExpenseItem expenseItem)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.ExpenseItem.Add(expenseItem);
            return db.SaveChanges() > 0;
        }

        public bool UpdateExpenseCategory(ExpenseCategory expenseItem)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(expenseItem).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public object DeleteExpenseCategory(ExpenseCategory expenseItem)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(expenseItem).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }

        public bool UpdateExpense(ExpenseItem expenseItem)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(expenseItem).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
