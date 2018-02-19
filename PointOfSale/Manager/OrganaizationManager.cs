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
        public bool InsertOrganaization(Organaization Organaization)
        {
            SuperShopDatabaseContext bd = new SuperShopDatabaseContext();
            bd.Organaization.Add(Organaization);
            return bd.SaveChanges() > 0;
        }

        public bool IsNameAlreadyExist(string name)
        {
            SuperShopDatabaseContext bd = new SuperShopDatabaseContext();
            bd.Organaization.Where(c => c.Name == name);
            return bd.SaveChanges() > 0;
        }

        public bool UpdateOrganaization(Organaization organaization)
        {
            SuperShopDatabaseContext bd = new SuperShopDatabaseContext();
            bd.Entry(organaization).State = EntityState.Modified;
            return bd.SaveChanges() > 0;
        }
    }
}
