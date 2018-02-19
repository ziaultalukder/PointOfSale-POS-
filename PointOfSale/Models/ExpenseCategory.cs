using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryCode { get; set; }
        public string categoryDescription { get; set; }
        public string CategoryType { get; set; }
        public int? Parentid { get; set; }
       
    }
}
