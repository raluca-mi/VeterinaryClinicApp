using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class HealthCertificate
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public Animal Animal { get; set; }
        public List<VaccineType> Vaccines { get; set; }

    }
}
