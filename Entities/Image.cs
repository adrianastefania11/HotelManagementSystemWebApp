using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public Room Room { get; set; }
    }
}
