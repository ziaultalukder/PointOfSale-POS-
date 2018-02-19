using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Expence
    {
        public int Id { get; set; }
        [Required]
        public decimal TotalAmmount { get; set; }
        [Required]
        public decimal Due { get; set; }

        [Required]
        public DateTime Date { get; set; }


        [Required]
        public int OutletId { get; set; }
        public Outlate Outlet { get; set; }


        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int ItemId { get; set; }
        public ItemSetups Item { get; set; }
        public virtual List<ExpenceItems> ExpenceList { get; set; }
    }
}
