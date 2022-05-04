using HotelManagementSystem.Repositories.images;
using HotelManagementSystem.Repositories.Rooms;
using HotelManagementSystem.Repositories.RoomTypes;
using HotelManagementSystem.Repositories.SessionTokens;
using HotelManagementSystem.Repositories.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories
{
   public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IRoomTypeRepository RoomType { get; }
        IRoomRepository Room { get; }
        IFeatureRepository Feature { get; }
        IImageRepository Image { get; }
        ISessionTokenRepository SessionToken { get; }



        Task SaveAsync();
    }
}
