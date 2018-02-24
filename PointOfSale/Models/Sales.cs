using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Due { get; set; }
        public string SalesNumber { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal Subtotal { get; set; }

        public int OutletId { get; set; }
        public Outlate Outlet { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int CustomerId { get; set; }
        public PartySetup Customer { get; set; }

        public virtual List<SalesItem> SalesItmLst { get; set; }
    }
}
