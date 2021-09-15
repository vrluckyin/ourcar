using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCar.Entity
{
    public class SubscriptionPayment : AuditableEntity
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Expiration { get; set; }

        public Subscription Subscription { get; set; }
    }
}
