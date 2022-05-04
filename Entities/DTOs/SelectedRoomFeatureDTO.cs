using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class SelectedRoomFeatureDTO
    {
        public string FeatureID { get; set; }
        public virtual Feature Feature { get; set; }
        public bool Selected { get; set; }
    }
}
