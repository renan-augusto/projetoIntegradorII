using ProjetoIntegradorII.Domain.Validations;
using static ProjetoIntegradorII.Domain.Entities.Enums;

namespace ProjetoIntegradorII.Domain.Entities
{
    public sealed class Title : Entity
    {
        public decimal Amount { get; private set; }
        public int BeneficiaryId { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? PaymentDate { get; private set; }
        public TitleStatus Status { get; set; } = TitleStatus.Pending;

        public Beneficiary Beneficiary { get; set; }

        public Title()
        {
            
        }

        public Title(decimal amount, DateTime dueDate, DateTime paymentDate, TitleStatus status)
        {
            ValidateDomain(amount, dueDate);
            Status = TitleStatus.Pending;

        }

        public void ValidateDomain(decimal amount, DateTime dueDate)
        {
            DomainExceptionValidation.When(amount <= 0, "Invalid value");
            DomainExceptionValidation.When(dueDate < DateTime.Now, "Invalid date");

            Amount = amount;
            DueDate = dueDate;
        }
    }
}
