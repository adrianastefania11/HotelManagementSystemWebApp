using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class ImageDTO
    {

        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public Room Room { get; set; }

        public ImageDTO(Image image)
        {
            this.Id = image.Id;
            this.ImageUrl = image.ImageUrl;
            this.Room = image.Room;
        }
    }
}
