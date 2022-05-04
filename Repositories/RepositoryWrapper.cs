using HotelManagementSystem.Data;
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
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly HotelContext _context;

        private IUserRepository _user;
        private IRoomTypeRepository _roomType;
        private IRoomRepository _room;
        private IFeatureRepository _feature;
        private IImageRepository _image;
        private ISessionTokenRepository _sessionToken;
        public RepositoryWrapper(HotelContext context)
        {
            _context = context;
        }
        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }

        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null) _sessionToken = new SessionTokenRepository(_context);
                return _sessionToken;
            }
        }

        public IRoomTypeRepository RoomType
        {
            get
            {
                if (_roomType == null) _roomType = new RoomTypeRepository(_context);
                return _roomType;
            }
        }
        public IRoomRepository Room
        {
            get
            {
                if (_room == null) _room = new RoomRepository(_context);
                return _room;
            }
        }

        public IFeatureRepository Feature
        {
            get
            {
                if (_feature == null) _feature = new FeatureRepository(_context);
                return _feature;
            }
        }
        public IImageRepository Image
        {
            get
            {
                if (_image == null) _image = new ImageRepository(_context);
                return _image;
            }
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
    

