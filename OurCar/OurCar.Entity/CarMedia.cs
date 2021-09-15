using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCar.Entity
{
    public class CarMedia : AuditableEntity
    {
        public int CarDetailId { get; set; }
        public int MediaId { get; set; }
        public bool IsVideo { get; set; }

        public Media Media { get; set; }
        public CarDetail CarDetail { get; set; }
    }
}
