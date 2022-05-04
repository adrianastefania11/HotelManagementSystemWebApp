using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class RoomsAndFeatures
    {
        public List<Room> Rooms { get; set; }
        public List<RoomFeature> Features { get; set; }
    }
}
