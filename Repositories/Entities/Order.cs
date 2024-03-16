using System;
using System.Collections.Generic;

namespace Repositories.Entities
{

    //test github in Order class
    // 2nd test in UI
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public float? Total { get; set; }
        public int? StaffId { get; set; }
        public DateTime? DeliverDate { get; set; }

        public virtual Staff? Staff { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
