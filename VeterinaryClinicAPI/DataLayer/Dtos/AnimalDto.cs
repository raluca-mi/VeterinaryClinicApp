using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dtos
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Breed { get; set; }
        public double Weight { get; set; }
    }
}
