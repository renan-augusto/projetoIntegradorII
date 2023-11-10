using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;
using ProjetoIntegradorII.Infra.Data.Context;

namespace ProjetoIntegradorII.Infra.Data.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        ApplicationDbContext _context;
        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Payment> Create(Payment payment)
        {
            _context.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> GetPaymentById(int id)
        {
            return await _context.Payments.FindAsync(id);
        }

        public Task<Payment> GetPaymentById(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Payment>> GetPayments()
        {
           return await _context.Payments.ToListAsync();
        }

        public async Task<Payment> Remove(Payment payment)
        {
           _context.Remove(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> Update(Payment payment)
        {
            _context.Update(payment);
            await _context.SaveChangesAsync();
            return payment;
        }
    }
}
