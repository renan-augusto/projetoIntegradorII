using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;
using ProjetoIntegradorII.Infra.Data.Context;

namespace ProjetoIntegradorII.Infra.Data.Repositories
{
    public class BeneficiaryRepository : IBeneficiaryRepository
    {
        ApplicationDbContext _context;

        public BeneficiaryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Beneficiary> CreateAsync(Beneficiary beneficiary)
        {
            _context.Add(beneficiary);
            await _context.SaveChangesAsync();
            return beneficiary;
        }

        public async Task<IEnumerable<Beneficiary>> GetBeneficiariesAsync()
        {
            return await _context.Beneficaries.ToListAsync();
        }

        public async Task<Beneficiary> GetBeneficiaryAdressAsync(int? id)
        {
            return await _context.Beneficaries.FindAsync(id);
        }

        public async Task<Beneficiary> GetByIdAsync(int? id)
        {
            return await _context.Beneficaries.FindAsync(id);
        }

        public async Task<Beneficiary> RemoveAsync(Beneficiary beneficiary)
        {
            _context.Remove(beneficiary);
            await _context.SaveChangesAsync();
            return beneficiary;

        }

        public async Task<Beneficiary> UpdateAsync(Beneficiary beneficiary)
        {
            _context.Update(beneficiary);
            await _context.SaveChangesAsync();
            return beneficiary;
        }
    }
}
