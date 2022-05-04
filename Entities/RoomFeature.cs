﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class RoomFeature
    {
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        public int FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
