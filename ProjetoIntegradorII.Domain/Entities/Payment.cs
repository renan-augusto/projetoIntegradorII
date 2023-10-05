using ProjetoIntegradorII.Domain.Validations;

namespace ProjetoIntegradorII.Domain.Entities
{
    public sealed class Payment : Entity
    {
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }

        public Payment(decimal amount, DateTime paymentDate, int title)
        {
            ValidateDomaing(amount, paymentDate);
            TitleId = title;
        }

        public void ValidateDomaing(decimal amount, DateTime paymentDate)
        {
            DomainExceptionValidation.When(amount <= 0, "Invalid value");
            DomainExceptionValidation.When(paymentDate < DateTime.Now, "Invalide date");

            Amount = amount;
            PaymentDate = paymentDate;
        }
    }
}
