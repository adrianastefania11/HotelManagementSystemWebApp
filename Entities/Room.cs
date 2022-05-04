using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int BookingId{ get; set; }
        public virtual Booking Booking{ get; set; }

        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int MaxGuests { get; set; }
        public virtual ICollection<RoomFeature> RoomFeatures { get; set; }
        public virtual ICollection<Image> RoomImages { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        
}
}
