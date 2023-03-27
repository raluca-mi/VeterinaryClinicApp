using DataLayer.Entities;
using DataLayer.Enums;

namespace DataLayer
{
    public class DbContext
    {
        public static List<Owner> Owners = new List<Owner>
        {
            new Owner
            {
                Id=1,
                FirstName="Chrisitian",
                LastName="Patt",
                PhoneNumber="0757412563",
                Animals=new List<Animal>
                {
                    new Animal
                    {
                        Id=1,
                        Name="Rocky",
                        Breed=Breed.Dog,
                        OwnerId=1,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=1,
                            Weight=5,
                            Vaccines = new List<VaccineType>
                            {
                                VaccineType.Rabies
                            }
                        }
                    },
                    new Animal
                    {
                        Id=2,
                        Name="Maya",
                        Breed=Breed.Dog,
                        OwnerId=1,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=2,
                            Weight=4,
                            Vaccines = new List<VaccineType>
                            {
                                VaccineType.Rabies,
                            }
                        }
                    }
                }
            },
            new Owner
            {
                Id= 2,
                FirstName="Anne",
                LastName="May",
                PhoneNumber="0788541236",
                Animals=new List<Animal>
                {
                    new Animal
                    {
                        Id=3,
                        Name="Kira",
                        Breed=Breed.Dog,
                        OwnerId=2,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=3,
                            Weight=6,
                            Vaccines = new List<VaccineType>
                            {
                                VaccineType.Bordetella
                            }
                        }
                    },
                    new Animal
                    {
                        Id=4,
                        Name="Kitty",
                        Breed=Breed.Cat,
                        OwnerId=2,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=4,
                            Weight=3,
                            Vaccines = new List<VaccineType>
                            {
                                VaccineType.FHV,
                                VaccineType.FeLV
                            }
                        }
                    },
                }
            },
            new Owner
            {
                Id= 3,
                FirstName="John",
                LastName="Blat",
                PhoneNumber="0722541236",
                Animals=new List<Animal>
                {
                    new Animal
                    {
                        Id=5,
                        Name="Amadeus",
                        Breed=Breed.Horse,
                        OwnerId=3,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=5,
                            Weight=700,
                            Vaccines = new List<VaccineType>
                            {
                               VaccineType.EEE
                            }
                        }
                    },
                    new Animal
                    {
                        Id=6,
                        Breed=Breed.Cow,
                        OwnerId=3,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=6,
                            Weight=900,
                            Vaccines = new List<VaccineType>
                            {
                                VaccineType.IBR
                            }
                        }
                    },
                }
            },
            new Owner
            {
                Id=4,
                FirstName="Maria",
                LastName="Brown",
                PhoneNumber="0785236541",
                Animals=new List<Animal>
                {
                    new Animal
                    {
                        Id=7,
                        Name="Carrot",
                        Breed=Breed.Rabbit,
                        OwnerId=4,
                        HealthCertificate = new HealthCertificate
                        {
                            Id=7,
                            Weight=0.5,
                            Vaccines = new List<VaccineType>
                            {
                                VaccineType.RVHD
                            }
                        }
                    },

                }
            }
        };

        public static List<Animal> Animals = Owners.SelectMany(o => o.Animals).ToList();
        

    }
}