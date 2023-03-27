using DataLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Enums;

namespace DataLayer.Mapping
{
    public static class AnimalsMappingExtensions
    {
        public static AnimalDto ToAnimalDto(this Animal animal)
        {
            if (animal == null) return null;

            var result = new AnimalDto();
            result.Id = animal.Id;
            result.Name = animal.Name;
            result.Weight = animal.HealthCertificate.Weight;

            switch (animal.Breed)
            {
                case Breed.Dog:
                    result.Breed = "Dog";
                    break;
                case Breed.Cat:
                    result.Breed = "Cat";
                    break;
                case Breed.Rabbit:
                    result.Breed = "Rabbit";
                    break;
                case Breed.Hamster:
                    result.Breed = "Hamster";
                    break;
                case Breed.Cow:
                    result.Breed = "Cow";
                    break;
                case Breed.Horse:
                    result.Breed = "Horse";
                    break;
                   
                default:
                    break;
            }

            return result;
        }
    }
}