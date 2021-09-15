using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCar.Entity
{
    public class CarDetail : AuditableEntity
    {
        public int CarId { get; set; }
        public int ManufaturingYear { get; set; }
        public int InsuranceStatusId { get; set; }
        public string SafetyDetail { get; set; }

        public virtual Car Car { get; set; }
        public virtual CarShared CarShared { get; set; }
        public virtual LookupItem InsuranceType { get; set; }
        public virtual ICollection<CarMedia> CarMedias { get; set; }
    }
}
