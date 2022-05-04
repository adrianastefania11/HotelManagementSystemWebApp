using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class CreateImageDTO
    {
     
        public string ImageUrl { get; set; }

        public Room Room { get; set; }
    }
}
