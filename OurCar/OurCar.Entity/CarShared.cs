using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OurCar.Common;

namespace OurCar.Entity
{
    public class CarShared : AuditableEntity
    {
        public int CarDetailId { get; set; }
        public DateTime Expiration { get; set; }
        public int? CurrentKeyHolderUserId { get; set; }
        public int? UpdateStatusUserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LimitedToPeople { get; set; }
        public RecordTypeCode StatusCode { get; set; }

        public CarDetail CarDetail { get; set; }

        public ICollection<CarSharedMember> CarSharedMembers { get; set; }
        public ICollection<CarKeyHolder> CarKeyHolders { get; set; }
    }
}
