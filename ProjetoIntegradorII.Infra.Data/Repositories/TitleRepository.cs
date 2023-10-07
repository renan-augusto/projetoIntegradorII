using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;
using ProjetoIntegradorII.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Infra.Data.Repositories
{
    public class TitleRepository : ITitleRepository
    {
        ApplicationDbContext _context;
        public TitleRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Title> Create(Title title)
        {
            _context.Add(title);
            await _context.SaveChangesAsync();
            return title;
        }

        public async Task<Title> GetTitleById(int id)
        {
            return await _context.Titles.FindAsync(id);


        }

        public async Task<IEnumerable<Title>> GetTitles()
        {
            return await _context.Titles.ToListAsync();
        }

        public async Task<Title> Remove(Title title)
        {
            _context.Remove(title);
            await _context.SaveChangesAsync();
            return title;
        }

        public async Task<Title> Update(Title title)
        {
            _context.Update(title);
            await _context.SaveChangesAsync();
            return title;
        }
    }
}
