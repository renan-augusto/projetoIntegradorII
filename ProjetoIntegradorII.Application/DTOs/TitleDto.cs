using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Application.DTOs
{
    public class TitleDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Status { get; set; }
        public int BeneficiaryId { get; set; }
    }
}
