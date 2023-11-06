using AutoMapper;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Beneficiary, BeneficiaryDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Title, TitleDto>().ReverseMap();

        }
    }
}
