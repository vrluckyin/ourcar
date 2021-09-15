using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurCar.Common;

namespace OurCar.Entity
{
    public class Media : AuditableEntity
    {
        public string MediaName { get; set; }
        public int MediaTypeId { get; set; }
        public string ContentKey { get; set; }
        public RecordTypeCode ProcessStatusCode { get; set; }

        public ICollection<CarMedia> CarMedias { get; set; }
    }
}
