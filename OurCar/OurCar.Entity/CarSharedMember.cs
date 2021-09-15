using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCar.Entity
{
    public class CarSharedMember : AuditableEntity
    {
        public int UserId { get; set; }
        public int CarSharedId { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime? RequestedOn { get; set; }

        public CarShared CarShared { get; set; }
    }
}
