using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class ItemSetups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalesPrice { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int CatagoryId { get; set; }
        public SetupItemCatagory Catagory { get; set; }
    }
}
