using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurCar.Common;

namespace OurCar.Entity
{
    public class CarKeyHolder : AuditableEntity
    {
        public int UserId { get; set; }
        public int CarSharedId { get; set; }
        public string SecurityCode { get; set; }
        public RecordTypeCode SecurityStatusCode { get; set; }

        public CarShared CarShared { get; set; }
    }
}
