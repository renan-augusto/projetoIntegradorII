using FluentAssertions;
using ProjetoIntegradorII.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Domain.Tests
{
    public class TitleUnityTest
    {
        [Fact]
        public void CreateTitle_WithValidParameters_ResultObjectValidState()
        {
            DateTime dueDate = new DateTime(2023, 10, 2, 10, 30, 0);
            DateTime paymentDate = new DateTime(2023, 10, 30, 10, 30, 0);
            Action action = () => new Title((decimal)10.00, dueDate, paymentDate, Enums.TitleStatus.Pending);
            action.Should()
                .NotThrow<ProjetoIntegradorII.Domain.Validations.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateTitle_WithInvalidDate_DomainExceptionValueInvalidDate()
        {
            DateTime dueDate = new DateTime(2022, 10, 1, 10, 30, 0);
            DateTime paymentDate = new DateTime(2022, 10, 30, 10, 30, 0);
            Action action = () => new Title((decimal)10.00, dueDate, paymentDate, Enums.TitleStatus.Pending);
            action.Should()
                .Throw<ProjetoIntegradorII.Domain.Validations.DomainExceptionValidation>()
                .WithMessage("Invalid date");
        }

        [Fact]
        public void CreateTitle_WithInvalidValue_DomainExceptionValueInvalidAmount()
        {
            DateTime dueDate = new DateTime(2023, 10, 1, 10, 30, 0);
            DateTime paymentDate = new DateTime(2023, 10, 30, 10, 30, 0);

            Action action = () => new Title((decimal)-10.00, dueDate, paymentDate, Enums.TitleStatus.Pending);
            action.Should()
                .Throw<ProjetoIntegradorII.Domain.Validations.DomainExceptionValidation>()
                .WithMessage("Invalid value");
        }
    }
}
