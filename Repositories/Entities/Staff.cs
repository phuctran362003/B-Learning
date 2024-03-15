using System;
using System.Collections.Generic;

namespace Repositories.Entities
{
    public partial class Staff
    {
        public Staff()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public bool IsManager { get; set; }
        public string? Account { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
