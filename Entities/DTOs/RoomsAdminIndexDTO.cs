using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class RoomsAdminIndexDTO
    {
        public List<Room> Rooms { get; set; }
        public List<RoomType> RoomTypes { get; set; }
    }
}
