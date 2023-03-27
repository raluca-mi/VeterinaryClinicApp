using DataLayer.Enums;

namespace DataLayer.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public HealthCertificate HealthCertificate { get; set; }
    }
}
