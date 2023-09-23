using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Domain.Interfaces
{
    public interface IBeneficiaryRepository
    {
        Task<IEnumerable<Beneficiary>> GetBeneficiariesAsync();
        Task<Beneficiary> GetByIdAsync(int? id);
        Task<Beneficiary> GetBeneficiaryAdressAsync(int? id);
        Task<Beneficiary> CreateAsync(Beneficiary beneficiary);
        Task<Beneficiary> UpdateAsync(Beneficiary beneficiary);
        Task<Beneficiary> RemoveAsync(Beneficiary beneficiary);
    }
}
