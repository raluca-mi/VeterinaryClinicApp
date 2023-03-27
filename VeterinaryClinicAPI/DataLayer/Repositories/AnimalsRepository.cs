using DataLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Mapping;


namespace DataLayer.Repositories
{
    public class AnimalsRepository
    {
        public List<Animal> GetAll()
        {
            var results = DbContext.Animals;
            return results;
        }

        public Animal GetById(int animalId)
        {
            var result = DbContext.Animals.Where(a => a.Id == animalId).FirstOrDefault();
            return result;
        }

        public bool DeleteById(int animalId)
        {
            var animal = DbContext.Animals.FirstOrDefault((a)=> a.Id== animalId);
            if (animal != null)
            {
                DbContext.Animals.Remove(animal);
                return true;
            }
            return false;
        }

    }
}
