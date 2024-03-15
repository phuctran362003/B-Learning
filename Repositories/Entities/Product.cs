using System;
using System.Collections.Generic;

namespace Repositories.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Guide { get; set; }
        public string? Country { get; set; }
        public float Price { get; set; }
        public float SellPrice { get; set; }
        public int Quantity { get; set; }

        public virtual ProductType ProductType { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
