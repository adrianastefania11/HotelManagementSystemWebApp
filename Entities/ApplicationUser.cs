using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class ApplicationUser: IdentityUser<int>
    {
        public ApplicationUser() : base() { }

        //[Column("FirstName")]
        public string FirstName { get; set; }
        //[Column("LastName")]
        public string LastName { get; set; }
     

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
