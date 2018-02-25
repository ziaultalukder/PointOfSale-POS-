using PointOfSale.Models;
using PointOfSale.UI;
using PointOfSale.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetupItemCatagory = PointOfSale.Models.SetupItemCatagory;

namespace PointOfSale.Manager
{
    public class SetupItemCatagoryManager
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        public bool InsertSetupItemCatagory(SetupItemCatagory setupItemCatagory)
        {
            db.SetupItemCatagories.Add(setupItemCatagory);
            return db.SaveChanges() > 0;
        }

        public bool UpdateItemCategory(SetupItemCatagory setupItemCatagory)
        {
            db.Entry(setupItemCatagory).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool DeleteItemCategory(SetupItemCatagory setupItemCatagory)
        {
            db.Entry(setupItemCatagory).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
        public bool IsNameAlreadyExist(string name)
        {
            db.SetupItemCatagories.Where(c => c.Name == name);
            return db.SaveChanges() > 0;
        }

    }
}
