using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Application.DTOs
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
    }
}
