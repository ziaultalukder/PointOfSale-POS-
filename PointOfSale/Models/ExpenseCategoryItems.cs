using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    class ExpenseCategoryItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CategoryCode { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public bool IsDelete { get; set; }      
    }
}
