using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VeterinaryClinicAPI.Controllers
{   
    [ApiController]
    [Route("api/animals")]
    public class AnimalsController : ControllerBase
    {

        private AnimalService animalService { get; set; }

        public AnimalsController(AnimalService animalService)
        {
            this.animalService = animalService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Animal>> GetAll()
        {
            var results = animalService.GetAll();
            return Ok(results);
        }

        [HttpGet("/get/{animalId}")]
        public ActionResult<Animal> GetById(int animalId)
        {
            var result = animalService.GetById(animalId);
            if (result == null)
            {
                return BadRequest("Animal not found!");
            }
            return Ok(result);
        }
    }
}
