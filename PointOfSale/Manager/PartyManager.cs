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
    public class PartyManager
    {
        public bool InsertParty(PartySetup partySetup)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.PartySetup.Add(partySetup);
            return db.SaveChanges() > 0;
        }

        public bool UpdateParty(PartySetup partySetup)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(partySetup).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }


        public object DeleteSetupParty(PartySetup partySetup)
        {
            SuperShopDatabaseContext db = new SuperShopDatabaseContext();
            db.Entry(partySetup).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
