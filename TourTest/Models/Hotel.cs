using System;
using System.Collections.Generic;

namespace TourTest.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            HotelComments = new HashSet<HotelComment>();
            HotelImages = new HashSet<HotelImage>();
            Tours = new HashSet<Tour>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountOfStars { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? Description { get; set; }

        public virtual Country CountryCodeNavigation { get; set; } = null!;
        public virtual ICollection<HotelComment> HotelComments { get; set; }
        public virtual ICollection<HotelImage> HotelImages { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
