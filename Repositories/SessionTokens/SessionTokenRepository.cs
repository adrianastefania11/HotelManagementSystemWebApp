using HotelManagementSystem.Data;
using HotelManagementSystem.Entities;
using HotelManagementSystem.Repositories.GenericRepository;
using HotelManagementSystem.Repositories.SessionTokens;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.SessionTokens
{
    public class SessionTokenRepository : GenericRepository<SessionToken>, ISessionTokenRepository
    {
        public SessionTokenRepository(HotelContext context) : base(context) { }

        
        public async Task<SessionToken> GetByJTI(string jti)
        {
        return await _context.SessionTokens.FirstOrDefaultAsync(t => t.Jti.Equals(jti));
        }

    }
}
