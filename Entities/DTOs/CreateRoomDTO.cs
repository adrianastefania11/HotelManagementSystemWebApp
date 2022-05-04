using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class CreateRoomDTO
    {
        public int Number { get; set; }
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
