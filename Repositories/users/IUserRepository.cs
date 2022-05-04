using HotelManagementSystem.Entities;
using HotelManagementSystem.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories.users
{
     public interface IUserRepository: IGenericRepository<ApplicationUser>
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<ApplicationUser> GetUserByEmail(string email);
        Task<ApplicationUser> GetByIdWithRoles(int id);
    }
}
