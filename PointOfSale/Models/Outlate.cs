using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Models
{
    public class Outlate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int OrganaizationId { get; set; }
        public Organaization Organaization { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}
