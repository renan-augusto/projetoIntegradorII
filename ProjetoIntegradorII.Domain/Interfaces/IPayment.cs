using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Domain.Interfaces
{
    public interface IPayment
    {
        Task<IEnumerable<Payment>> GetPayments();
        Task<Payment> GetPaymentById(int id);
        Task<Payment> Create(Payment payment);
        Task<Payment> Update(Payment payment);
        Task<Payment> Remove(Payment payment);
    }
}
