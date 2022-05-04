using HotelManagementSystem.Data;
using HotelManagementSystem.Entities;
using HotelManagementSystem.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.Rooms
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(HotelContext context) : base(context) { }

        public async Task<IEnumerable<Feature>> GetAllFeaturesAsync()
        {
            return await _context.Features.ToArrayAsync();
        }


    }
}
