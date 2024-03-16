using System;
using System.Collections.Generic;

namespace Repositories.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CountryOfOrigin { get; set; }
        public int? TypeId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual ProductType? Type { get; set; }
    }
}
