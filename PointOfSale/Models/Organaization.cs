using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Organaization
    {
        public int Id { get; set; }
        [StringLength(155)]
        public string Name { get; set; }
        [StringLength(155)]
        public string Code { get; set; }
        [StringLength(20)]
        public string Contact { get; set; }
        [StringLength(555)]
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public List<Outlate> ListOutlates { get; set; }

    }
}
