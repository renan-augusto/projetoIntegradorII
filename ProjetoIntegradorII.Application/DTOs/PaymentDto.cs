using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Application.DTOs
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
    }
}
