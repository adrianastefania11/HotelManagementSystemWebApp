using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class CreateRoomTypeDTO
    {
        public string Name { get; set; }

        public Room Room { get; set; }
    }
}
