using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Domain.Interfaces
{
    public interface IAdressRepository
    {
        Task<IEnumerable<Adress>> GetAdresses();
        Task<Adress> GetAdressById(int? id);
        Task<Adress> Create(Adress adress);
        Task<Adress> Update(Adress adress);
        Task<Adress> Remove(Adress adress);
    }
}
