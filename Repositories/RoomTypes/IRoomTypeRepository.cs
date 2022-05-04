using HotelManagementSystem.Repositories.GenericRepository;
using HotelManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.RoomTypes
{
     public interface IRoomTypeRepository : IGenericRepository<RoomType>
    {
        Task<IEnumerable<RoomType>> GetAllRoomTypesAsync();
        Task<RoomType> GetByIdWithName(int id);
     



    }
}
