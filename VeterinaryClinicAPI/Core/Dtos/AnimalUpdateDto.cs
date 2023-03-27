using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class AnimalUpdateDto
    {
        public int Id { get; set; }
        public HealthCertificateUpdateDto HealthCertificate { get; set; }
        
    }
}
