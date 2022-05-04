 using HotelManagementSystem.Entities;
using HotelManagementSystem.Entities.DTOs;
using HotelManagementSystem.Repositories.Rooms;
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
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _repository;

        public RoomController(IRoomRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoom()
        {
            var rooms = await _repository.GetAllRoomsAsync();

            var roomToReturn = new List<RoomDTO>();

            foreach (var room in rooms)
            {
                roomToReturn.Add(new RoomDTO(room));
            }

            return Ok(roomToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomTypeById(int id)
        {
            var room = await _repository.GetByIdWithNumber(id);

            return Ok(new RoomDTO(room));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var room = await _repository.GetByIdAsync(id);

            if (room == null)
            {
                return NotFound("RoomType does not exist!");
            }

            _repository.Delete(room);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRoomType(CreateRoomDTO dto)
        {
            Room newRoom = new Room();

            newRoom.Number = dto.Number;
            newRoom.RoomTypeId = dto.RoomTypeId;
            newRoom.RoomType = dto.RoomType;


            _repository.Create(newRoom);

            await _repository.SaveAsync();


            return Ok(new RoomDTO(newRoom));
        }

    }
}
