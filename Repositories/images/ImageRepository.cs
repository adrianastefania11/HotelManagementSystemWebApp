using HotelManagementSystem.Entities;
using HotelManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementSystem.Entities.DTOs;

namespace HotelManagementSystem.Repositories.images

{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(HotelContext context) : base(context) { }

        public async Task<IEnumerable<Image>> GetAllImagesAsync()
        {
            return await _context.Images.ToArrayAsync();
        }

        public async Task<RoomFeaturesAndImagesDTO> GetRoomFeaturesAndImagesAsync(Room room)
        {
            var RoomImagesRelationship = _context.Rooms;
            var images = new List<Image>();
            foreach (var RoomImage in RoomImagesRelationship)
            {
                var Image = await _context.Images.FindAsync();
                images.Add(Image);
            }


            var RoomFeaturesRelationship = _context.RoomFeatures.Where(x => x.RoomId == room.Id);
            var features = new List<Feature>();
            foreach (var RoomFeature in RoomFeaturesRelationship)
            {
                var Feature = await _context.Features.FindAsync(RoomFeature.FeatureId);
                features.Add(Feature);
            }

            var ImagesAndFeatures = new RoomFeaturesAndImagesDTO
            {
                Images = images,
                Features = features
            };
            return ImagesAndFeatures;
        }



        public async Task RemoveImageAsync(Image image)
        {
            _context.Images.Remove(image);
            await _context.SaveChangesAsync();
        }

    
    }
}
