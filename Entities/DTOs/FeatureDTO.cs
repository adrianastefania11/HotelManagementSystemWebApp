using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class FeatureDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public virtual List<RoomFeature> RoomFeatures { get; set; }
        public FeatureDTO(Feature feature)
        {
            this.Id = feature.Id;
            this.Name = feature.Name;
            this.Icon = feature.Icon;
            this.RoomFeatures = new List<RoomFeature>();
        }
    }
}
