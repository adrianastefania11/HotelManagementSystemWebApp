using HotelManagementSystem.Entities;
using HotelManagementSystem.Entities.DTOs;
using HotelManagementSystem.Repositories.images;
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
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository _repository;
        public ImagesController(IImageRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllImages()
        {
            var images = await _repository.GetAllImagesAsync();
            var imageToReturn = new List<ImageDTO>();

            foreach (var image in images)
            {
                imageToReturn.Add(new ImageDTO(image));
            }

            return Ok(imageToReturn);
        }

         [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteImage(int id)
            {
                var image = await _repository.GetByIdAsync(id);

                if (image == null)
                {
                    return NotFound("Image does not exist!");
                }

                _repository.Delete(image);

                await _repository.SaveAsync();

                return NoContent();
            }
        [HttpPost]
        public async Task<IActionResult> CreateImage(CreateImageDTO dto)
        {
            Image newImg = new Image();


            newImg.ImageUrl = dto.ImageUrl;
            newImg.Room = dto.Room;


            _repository.Create(newImg);

            await _repository.SaveAsync();


            return Ok(new ImageDTO(newImg));

        }

    }




    }

