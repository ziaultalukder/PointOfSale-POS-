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
    public class ItemSetupManager
    {
        public bool InsertSetupItemCatagory(ItemSetups itemSetup)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.ItemSetups.Add(itemSetup);
            return db.SaveChanges() > 0;
        }

        public bool UpdateSetupItemCatagory(ItemSetups itemSetup)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(itemSetup).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
