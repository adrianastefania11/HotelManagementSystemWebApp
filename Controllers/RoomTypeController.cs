using HotelManagementSystem.Entities;
using HotelManagementSystem.Entities.DTOs;
using HotelManagementSystem.Repositories.RoomTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeRepository _repository;

        public RoomTypeController(IRoomTypeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRoomTypes()
        {
            var roomTypes = await _repository.GetAllRoomTypesAsync();

            var roomTypesToReturn = new List<RoomTypeDTO>();

            foreach (var roomType in roomTypes)
            {
                roomTypesToReturn.Add(new RoomTypeDTO(roomType));
            }

            return Ok(roomTypesToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomTypeById(int id)
        {
            var roomType = await _repository.GetByIdWithName(id);

            return Ok(new RoomTypeDTO(roomType));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomType(int id)
        {
            var roomType = await _repository.GetByIdAsync(id);

            if (roomType == null)
            {
                return NotFound("RoomType does not exist!");
            }

            _repository.Delete(roomType);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRoomType(CreateRoomTypeDTO dto)
        {
            RoomType newRoomType = new RoomType();

            newRoomType.Name = dto.Name;
            newRoomType.Room = dto.Room;

            _repository.Create(newRoomType);

            await _repository.SaveAsync();


            return Ok(new RoomTypeDTO(newRoomType));
        }

       
    }

}

