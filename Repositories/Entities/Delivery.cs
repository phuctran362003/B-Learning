using System;
using System.Collections.Generic;

namespace Repositories.Entities
{
    public partial class Delivery
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual Order? Order { get; set; }
        public virtual staff? Staff { get; set; }
    }
}
