using PointOfSale.Models;
using PointOfSale.UI;
using PointOfSale.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Manager
{
    public class ExpenseCategoryManager
    {
        public bool InsertExpenseCategory(ExpenseCategory expenseCategory)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.ExpenseCategory.Add(expenseCategory);
            return db.SaveChanges() > 0;
        }

        public bool UpdateExpenseCategory(ExpenseCategory expenseCategory)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(expenseCategory).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public object DeleteExpenseCategory(ExpenseCategory expenseCategory)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(expenseCategory).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
