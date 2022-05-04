using HotelManagementSystem.Entities;
using HotelManagementSystem.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.SessionTokens
{
     public interface ISessionTokenRepository: IGenericRepository<SessionToken>
    {
        Task<SessionToken> GetByJTI(string jti);
    }
}
