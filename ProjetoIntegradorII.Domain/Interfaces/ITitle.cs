using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Domain.Interfaces
{
    public interface ITitle
    {
        Task<IEnumerable<Title>> GetTitles();
        Task<Title> GetTitleById(Title title);
        Task<Title> Create(Title title);
        Task<Title> Update(Title title);
        Task<Title> Remove(Title title);
    }
}
