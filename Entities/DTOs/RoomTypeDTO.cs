using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class RoomTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Room Room { get; set; }

        public RoomTypeDTO( RoomType roomType)
        {
            this.Id = roomType.Id;
            this.Name = roomType.Name;
            this.Price = roomType.Price;
            this.Description = roomType.Description;
            this.ImageUrl = roomType.ImageUrl;
            this.Room = roomType.Room;

        }
    }
}
