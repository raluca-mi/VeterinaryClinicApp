using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
