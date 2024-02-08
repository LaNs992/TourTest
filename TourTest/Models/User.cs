using System;
using System.Collections.Generic;

namespace TourTest.Models
{
    public partial class User
    {
        public int id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
