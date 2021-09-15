using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCar.Entity
{
    public class LookupItem : AuditableEntity
    {
        public string ItemGroup { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }

        public ICollection<Car> Cars { get; set; }
        public ICollection<CarDetail> CarDetails { get; set; }
    }
}
