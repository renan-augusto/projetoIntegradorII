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
        public string Name { get; private set; }
        public int LegalNature { get; private set; }
        public string Phone { get; private set; }
        public bool Active { get; private set; }
        public int AdressId { get; set; }
        public Adress? Adress { get; set; }
    }
}
