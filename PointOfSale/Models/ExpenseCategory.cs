using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [Required]
        [Range(1000,9999999)]
        public int CategoryCode { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryType { get; set; }
        public int? Parentid { get; set; }
        public string ParentName { get; set; }
        public bool IsDelete { get; set; }        
    }
}
