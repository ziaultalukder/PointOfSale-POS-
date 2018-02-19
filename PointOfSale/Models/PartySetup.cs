using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class PartySetup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime DataTime { get; set; }
        public string Customer { get; set; }
        public string Supplier { get; set; }
    }
}
