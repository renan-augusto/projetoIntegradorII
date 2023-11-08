using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Domain.Interfaces
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetPayments();
        Task<Payment> GetPaymentById(int? id);
        Task<Payment> Create(Payment payment);
        Task<Payment> Update(Payment payment);
        Task<Payment> Remove(Payment payment);
    }
}
