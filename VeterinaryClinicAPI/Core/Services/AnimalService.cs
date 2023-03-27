using DataLayer.Repositories;
using DataLayer.Entities;
using Core.Dtos;

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
        public Animal GetById(int animalId)
        {
            var result = animalsRepository.GetById(animalId);
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

        
    }
}
