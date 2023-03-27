using DataLayer.Repositories;
using DataLayer.Entities;
using Core.Dtos;
using DataLayer.Mapping;
using DataLayer.Dtos;

namespace Core.Services
{
    public class AnimalService
    {
        private AnimalsRepository animalsRepository { get; set; }
        public AnimalService(AnimalsRepository animalsRepository)
        {
            this.animalsRepository = animalsRepository;
        }

        public List<Animal> GetAll()
        {
            var result = animalsRepository.GetAll();
            return result;
        }
        public AnimalDto GetById(int animalId)
        {
            var result = animalsRepository.GetById(animalId).ToAnimalDto();
            
            return result;
        }

        public bool EditWeight(AnimalUpdateDto payload)
        {
            if (payload == null || payload.HealthCertificate.Weight == null)
            {
                return false;
            }

            var result = animalsRepository.GetById(payload.Id);
            if (result == null) return false;

            result.HealthCertificate.Weight = payload.HealthCertificate.Weight;

            return true;
        }

        public bool DeleteAnimal(int animalId) {
           
            return animalsRepository.DeleteById(animalId);
        }

        
    }
}
