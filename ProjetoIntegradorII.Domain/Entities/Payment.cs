using ProjetoIntegradorII.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorII.Domain.Entities
{
    public sealed class Payment : Entity
    {
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; set; }
        public Title Title { get; set; }

        public Payment(decimal amount, DateTime paymentDate, Title title) 
        {
            ValidateDomaing(amount, paymentDate, title);
        }

        public void ValidateDomaing(decimal amount, DateTime paymentDate, Title title) 
        {
            DomainExceptionValidation.When(amount <= 0, "Invalid value");
            DomainExceptionValidation.When(paymentDate < DateTime.Now, "Invalide date");
            DomainExceptionValidation.When(title == null, "Invalid title");

            Amount = amount;
            PaymentDate = paymentDate;
            Title = title;
        }
    }
}
