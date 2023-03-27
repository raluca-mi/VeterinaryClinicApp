using Core.Dtos;
using Core.Services;
using DataLayer.Dtos;
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
        public ActionResult<AnimalDto> GetById(int animalId)
        {
            var result = animalService.GetById(animalId);
            if (result == null)
            {
                return BadRequest("Animal not found!");
            }
            return Ok(result);
        }

        [HttpPatch("/edit-weight")]
        public ActionResult<bool> EditWeight([FromBody] AnimalUpdateDto payload)
        {
            var result = animalService.EditWeight(payload);

            if (!result)
            {
                return BadRequest("Animal could not be updated.");
            }

            return result;
        }

        [HttpDelete("/delete/{animalId}")]
        public ActionResult<bool> DeleteAnimal(int animalId) { 
        
            if(animalId ==null)
            {
                return NotFound("Animal not found");
            }
            
            var result = animalService.DeleteAnimal(animalId);
            if(result)
            {
                return Ok("Animal deleted succsessfully");
            }
            return NotFound("Animal not found!");
        }

    }
}
