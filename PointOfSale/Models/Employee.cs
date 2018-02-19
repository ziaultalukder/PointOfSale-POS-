using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public DateTime JoinintDate { get; set; }
        public string EmergencyNumber { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nid { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public byte[] Image { get; set; }
        public int OutlateId { get; set; }
        public Outlate Outlate { get; set; }
    }
}
