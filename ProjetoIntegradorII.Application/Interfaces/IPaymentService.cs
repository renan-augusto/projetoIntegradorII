using ProjetoIntegradorII.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Application.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDto>> GetPayments();
        Task<PaymentDto> GetPaymentById(int? id);
        Task<PaymentDto> Add(PaymentDto paymentDto);
        Task<PaymentDto> Update(PaymentDto paymentDto);
        Task Remove(int id);
    }
}
