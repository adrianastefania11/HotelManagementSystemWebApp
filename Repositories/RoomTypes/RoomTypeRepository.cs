using HotelManagementSystem.Repositories.GenericRepository;
using HotelManagementSystem.Data;
using HotelManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.RoomTypes
{
    public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(HotelContext context) : base(context) { }

        public async Task<IEnumerable<RoomType>> GetAllRoomTypesAsync()
        {
            return await _context.RoomTypes.ToArrayAsync();
        }

        public  async Task<RoomType> GetByIdWithName(int id)
        {
            return await _context.RoomTypes.Include(a => a.Name).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        
    }
}
