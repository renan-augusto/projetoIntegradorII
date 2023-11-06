using ProjetoIntegradorII.Application.DTOs;

namespace ProjetoIntegradorII.Application.Interfaces
{
    public interface IBeneficiaryService
    {
        Task<IEnumerable<BeneficiaryDto>> GetBeneficiaries();
        Task<BeneficiaryDto> GetBeneficiaryById(int? id);
        Task<BeneficiaryDto> Add(BeneficiaryDto beneficaryDto);
        Task<BeneficiaryDto> Update(BeneficiaryDto beneficiaryDto);
        Task Remove(int id);
    }
}
