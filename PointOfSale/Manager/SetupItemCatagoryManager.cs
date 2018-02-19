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
        public bool InsertSetupItemCatagory(SetupItemCatagory setupItemCatagory)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.SetupItemCatagories.Add(setupItemCatagory);
            return db.SaveChanges() > 0;
        }

        public bool UpdateItemCategory(SetupItemCatagory setupItemCatagory)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(setupItemCatagory).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        
    }
}
