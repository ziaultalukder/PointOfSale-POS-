using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.DatabaseContext;
using PointOfSale.Models;

namespace PointOfSale.Manager
{
    public class EmployeeManager
    {
        public bool InsertEmployee(Employee employee)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Employee.Add(employee);
            return db.SaveChanges() > 0;
        }

        public bool UpdatedEmployee(Employee employee)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(employee).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
