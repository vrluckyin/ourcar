using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurCar.Common;

namespace OurCar.Entity
{
    public class Subscription : AuditableEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int ValidityInMonths { get; set; }
        public RecordTypeCode StatusCode { get; set; }

        public ICollection<SubscriptionCarShared> SubscriptionCarShareds { get; set; }
        public ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
