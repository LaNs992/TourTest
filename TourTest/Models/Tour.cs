using System;
using System.Collections.Generic;

namespace TourTest.Models
{
    public partial class Tour
    {
        public Tour()
        {
            Orders = new HashSet<Order>();
            Hotels = new HashSet<Hotel>();
            Types = new HashSet<Type>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string TourCountry { get; set; } = null!;
        public int TicketCount { get; set; }
        public string? Description { get; set; }
        public byte[]? ImagePreview { get; set; }
        public decimal Price { get; set; }
        public bool IsActual { get; set; }
        public bool IsInternational { get; set; }

        public virtual Country TourCountryNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<Type> Types { get; set; }
    }
}
