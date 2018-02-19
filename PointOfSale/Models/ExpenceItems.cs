using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class ExpenceItems
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string ItemName { get; set; }

        [Required]
        [StringLength(555)]
        public string Remarks { get; set; }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal LineTotal { get; set; }
        public int ExpenceId { get; set; }
        public Expence Expence { get; set; }
    }
}
