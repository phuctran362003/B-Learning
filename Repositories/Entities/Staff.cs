using System;
using System.Collections.Generic;

namespace Repositories.Entities
{
    public partial class staff
    {
        public staff()
        {
            Deliveries = new HashSet<Delivery>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Type { get; set; }
        public string? BankAccount { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
