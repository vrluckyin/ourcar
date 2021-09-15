using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCar.Entity
{
    public class Car : AuditableEntity
    {
        public int CompanyId { get; set; }
        public int CarTypeId { get; set; }
        public string Model { get; set; }

        public ICollection<CarDetail> CarDetails { get; set; }
        public LookupItem Company { get; set; }
        public LookupItem CarType { get; set; }
    }
}
