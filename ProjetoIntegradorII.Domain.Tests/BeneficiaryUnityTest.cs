using FluentAssertions;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Domain.Tests
{
    public class BeneficiaryUnityTest
    {
        [Fact]
        public void CreateBeneficiary_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Beneficiary("Benefiary name", 2, "1799999999");
            action.Should()
                .NotThrow<ProjetoIntegradorII.Domain.Validations.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateBeneficiary_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Beneficiary("e", 2, "1799999999");
            action.Should()
                .Throw<ProjetoIntegradorII.Domain.Validations.DomainExceptionValidation>()
                .WithMessage("Invalid name. Minimum 3 chars");
                   
        }
    }
}