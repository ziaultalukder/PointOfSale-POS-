using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required]
        public decimal TotalAmmount { get; set; }
        [Required]
        public decimal Due { get; set; }
        [Required]
        [StringLength(1000)]
        public string Remarks { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string SalesNumber { get; set; }

        [Required]
        public int OutletId { get; set; }
        public Outlate Outlet { get; set; }


        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        [Required]
        public int PartyTypeId { get; set; }
        public PartySetup PartyType { get; set; }


        [Required]
        public int ItemId { get; set; }
        public ItemSetups Item { get; set; }

        public virtual List<PurchaseItem> PurchaseItemList { get; set; }
    }
}
