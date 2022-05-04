using HotelManagementSystem.Repositories.GenericRepository;
using HotelManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.Rooms
{
    public  interface IRoomRepository : IGenericRepository<Room>
    {
        Task<IEnumerable<Room>> GetAllRoomsAsync();
        void UpdateRoomFeaturesList(Room room, int[] SelectedFeatureIDs);
        Task<Room> GetByPrice(Decimal price);
        Task<Room> GetByIdWithNumber(int id);


    }
}
