using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;
using ProjetoIntegradorII.Infra.Data.Context;

namespace ProjetoIntegradorII.Infra.Data.Repositories
{
    public class AdressRepository : IAdressRepository
    {
        ApplicationDbContext _context;

        public AdressRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Adress> Create(Adress adress)
        {
            _context.Adresses.Add(adress);
            await _context.SaveChangesAsync();
            return adress;
        }

        public async Task<Adress> GetAdressById(int? id)
        {
            return await _context.Adresses.FindAsync(id);
        }

        public async Task<IEnumerable<Adress>> GetAdresses()
        {
            return await _context.Adresses.ToListAsync();
        }

        public async Task<Adress> Remove(Adress adress)
        {
            _context?.Remove(adress);
            await _context.SaveChangesAsync();
            return adress;
        }

        public async Task<Adress> Update(Adress adress)
        {
            _context.Update(adress);
            await _context.SaveChangesAsync();
            return adress;
        }
    }
}
