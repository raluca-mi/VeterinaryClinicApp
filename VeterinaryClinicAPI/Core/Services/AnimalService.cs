using DataLayer.Repositories;
using DataLayer.Entities;

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

        
    }
}
