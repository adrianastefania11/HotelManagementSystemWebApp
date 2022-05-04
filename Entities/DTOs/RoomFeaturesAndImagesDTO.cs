using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class RoomFeaturesAndImagesDTO
    {
        public List<Image> Images { get; set; }
        public List<Feature> Features { get; set; }
    }
}
