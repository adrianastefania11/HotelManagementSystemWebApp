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
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureRepository _repository;
        public FeatureController(IFeatureRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFeatures()
        {
            var features = await _repository.GetAllFeaturesAsync();

            var featuresToReturn = new List<FeatureDTO>();

            foreach (var feature in features)
            {
                featuresToReturn.Add(new FeatureDTO(feature));
            }

            return Ok(featuresToReturn);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeatureType(int id)
        {
            var feature = await _repository.GetByIdAsync(id);

            if (feature == null)
            {
                return NotFound("Feature does not exist!");
            }

            _repository.Delete(feature);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDTO dto)
        {
            Feature newFeature = new Feature();

            newFeature.Name = dto.Name;

            _repository.Create(newFeature);

            await _repository.SaveAsync();


            return Ok(new FeatureDTO(newFeature));
        }
    }
}
