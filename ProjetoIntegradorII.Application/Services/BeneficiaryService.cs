using AutoMapper;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Application.Interfaces;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;

namespace ProjetoIntegradorII.Application.Services
{
    public class BeneficiaryService : IBeneficiaryService
    {
        private IBeneficiaryRepository _beneficiaryRepository;

        private readonly IMapper _mapper;

        public BeneficiaryService(IBeneficiaryRepository beneficiaryRepository, IMapper mapper)
        {
            _beneficiaryRepository = beneficiaryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BeneficiaryDto>> GetBeneficiaries()
        {
            var beneficiariesEntity = await _beneficiaryRepository.GetBeneficiariesAsync();
            return _mapper.Map<IEnumerable<BeneficiaryDto>>(beneficiariesEntity);
        }

        public async Task<BeneficiaryDto> GetBeneficiaryById(int? id)
        {
            var beneficiaryEntity = await _beneficiaryRepository.GetByIdAsync(id);
            return _mapper.Map<BeneficiaryDto>(beneficiaryEntity);
        }

        public async Task<BeneficiaryDto> Add(BeneficiaryDto beneficiaryDto)
        {
            var beneficiaryEntity = _mapper.Map<Beneficiary>(beneficiaryDto);
            await _beneficiaryRepository.CreateAsync(beneficiaryEntity);
            return _mapper.Map<BeneficiaryDto>(beneficiaryEntity);

        }

        public async Task<BeneficiaryDto> Update(BeneficiaryDto beneficiaryDto)
        {
            var beneficiaryEntity = _mapper.Map<Beneficiary>(beneficiaryDto);
            await _beneficiaryRepository.UpdateAsync(beneficiaryEntity);
            return _mapper.Map<BeneficiaryDto>(beneficiaryEntity);
        }

        public async Task Remove(int id)
        {
            var beneficiaryEntity = _beneficiaryRepository.GetByIdAsync(id).Result;
            await _beneficiaryRepository.RemoveAsync(beneficiaryEntity);
        }
    }
}
