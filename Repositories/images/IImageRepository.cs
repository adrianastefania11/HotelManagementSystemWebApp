using HotelManagementSystem.Entities;
using HotelManagementSystem.Entities.DTOs;
using HotelManagementSystem.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.images
{
     public interface IImageRepository : IGenericRepository<Image>
    {
        Task<IEnumerable<Image>> GetAllImagesAsync();
        Task RemoveImageAsync(Image image);

        Task<RoomFeaturesAndImagesDTO> GetRoomFeaturesAndImagesAsync(Room room);

    }
}
