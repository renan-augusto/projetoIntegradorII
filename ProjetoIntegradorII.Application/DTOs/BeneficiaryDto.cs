using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Application.DTOs
{
    public class BeneficiaryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LegalNature { get; set; }
        public string Phone { get; set; }

    }
}
