using System;
using System.Collections.Generic;

namespace Repositories.Entities
{
    public partial class Order
    {
        public Order()
        {
            Deliveries = new HashSet<Delivery>();
        }

        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerPhone { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
