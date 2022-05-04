using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public virtual ICollection<RoomFeature> RoomFeatures { get; set; }
    }
}
