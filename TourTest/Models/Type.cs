using System;
using System.Collections.Generic;

namespace TourTest.Models
{
    public partial class Type
    {
        public Type()
        {
            Tours = new HashSet<Tour>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
