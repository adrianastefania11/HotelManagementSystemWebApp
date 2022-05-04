using HotelManagementSystem.Entities;
using HotelManagementSystem.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.Rooms
{
    public interface IFeatureRepository: IGenericRepository<Feature>
    {
        Task<IEnumerable<Feature>> GetAllFeaturesAsync();
    }
}
