using System;
using System.Collections.Generic;

namespace TourTest.Models
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public DateTimeOffset? DateOrder { get; set; } = DateTimeOffset.Now;
        public int TourId { get; set; }
        public int Cost { get; set; }
        public double? Discount { get; set; }
        public string PickUpPoint { get; set; } = null!;
        public string? User { get; set; }
        public int PickUpCode { get; set; }

        public virtual Tour Tour { get; set; } = null!;
      
    }
}
