using System;
using System.Collections.Generic;

#nullable disable

namespace PRNAssG8.Models
{
    public partial class Reservation
    {
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? Time { get; set; }
        public double? NewPrice { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
