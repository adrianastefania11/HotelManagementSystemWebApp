using HotelManagementSystem.Repositories.GenericRepository;
using HotelManagementSystem.Data;
using HotelManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.Rooms
{
    public class RoomRepository: GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelContext context) : base(context) { }

        public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
            return await _context.Rooms.ToArrayAsync();
        }


        public async  Task<Room> GetByPrice(decimal price)
        {
            return await _context.Rooms.Where(a => a.Price.Equals(price)).FirstOrDefaultAsync();
        }

        public void UpdateRoomFeaturesList(Room room, int[] SelectedFeatureIDs)
        {
            var PreviouslySelectedFeatures = _context.RoomFeatures.Where(x => x.RoomId == room.Id);
            _context.RoomFeatures.RemoveRange(PreviouslySelectedFeatures);
            _context.SaveChanges();


            if (SelectedFeatureIDs != null)
            {
                foreach (var featureID in SelectedFeatureIDs)
                {
                    var AllFeatureIDs = new HashSet<int>(_context.Features.Select(x => x.Id));
                    if (AllFeatureIDs.Contains(featureID))
                    {
                        _context.RoomFeatures.Add(new RoomFeature
                        {
                            FeatureId = featureID,
                            RoomId = room.Id
                        });
                    }
                }
                _context.SaveChanges();

            }
        }

        public async Task<Room> GetByIdWithNumber(int id)
        {
            return await _context.Rooms.Include(a => a.Number).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

    }
}
