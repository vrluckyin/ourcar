using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurCar.Common;

namespace OurCar.Entity
{
    public class SubscriptionCarShared : AuditableEntity
    {
        public int CarSharedId { get; set; }
        public int SubscriptionId { get; set; }
        public RecordTypeCode StatusCode { get; set; }

        public CarShared CarShared { get; set; }
        public Subscription Subscription { get; set; }

    }
}
