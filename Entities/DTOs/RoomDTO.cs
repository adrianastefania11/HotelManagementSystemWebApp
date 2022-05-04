using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Entities.DTOs
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }

        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int MaxGuests { get; set; }
        public virtual List<RoomFeature> RoomFeatures { get; set; }
        public virtual List<Image> RoomImages { get; set; }
        public virtual List<Review> Reviews { get; set; }

        public RoomDTO(Room room)
        {
            this.Id = room.Id;
            this.Number = room.Number;
            this.BookingId = room.BookingId;
            this.Booking = room.Booking;
            this.RoomTypeId = room.RoomTypeId;
            this.RoomType = room.RoomType;
            this.Price = room.Price;
            this.Available = room.Available;
            this.Description = room.Description;
            this.MaxGuests = room.MaxGuests;
            this.RoomFeatures = new List<RoomFeature>();
            this.RoomImages = new List<Image>();
            this.Reviews = new List<Review>();
        } 
    }
}
