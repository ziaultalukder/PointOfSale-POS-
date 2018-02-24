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
    public class OutlateManager
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        public bool Insertoutlate(Outlate outlate)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Outlates.Add(outlate);
            return db.SaveChanges() > 0;
        }

        public bool Updateoutlate(Outlate outlate)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(outlate).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool DeleteOutlet(Outlate outlate)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(outlate).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
