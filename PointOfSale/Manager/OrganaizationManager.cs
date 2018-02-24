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
    public class OrganaizationManager
    {
        SuperShopDatabaseContext db = new SuperShopDatabaseContext();
        public bool InsertOrganaization(Organaization Organaization)
        {
            db.Organaization.Add(Organaization);
            return db.SaveChanges() > 0;
        }

        public bool IsNameAlreadyExist(string name)
        {
            db.Organaization.Where(c => c.Name == name);
            return db.SaveChanges() > 0;
        }

        public bool IsContactNoAlreadyExist(string contact)
        {
            db.Organaization.Where(c => c.Contact == contact);
            return db.SaveChanges() > 0;
        }

        public bool UpdateOrganaization(Organaization organaization)
        {
            db.Entry(organaization).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
