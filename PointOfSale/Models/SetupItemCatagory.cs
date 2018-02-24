using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class SetupItemCatagory
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(55)]
        public string CatagoryType { get; set; }

        public byte[] Image { get; set; }
        public int? CatagoryId { get; set; }
        public SetupItemCatagory Catagory { get; set; }
        //public bool  IsDelete { get; set; }

    }
}
