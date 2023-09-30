using ProjetoIntegradorII.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoIntegradorII.Domain.Entities.Enums;

namespace ProjetoIntegradorII.Domain.Entities
{
    public class Title : Entity
    {
        public decimal Amount { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public TitleStatus Status { get; set; } = TitleStatus.Pending;

        public Title(decimal amount, DateTime dueDate, DateTime paymentDate, TitleStatus status) 
        {
            ValidateDomain(amount, dueDate, paymentDate);
            Status = TitleStatus.Pending;
            
        }

        public void ValidateDomain(decimal amount, DateTime dueDate, DateTime paymentDate)
        {
            DomainExceptionValidation.When(amount <= 0, "Invalid value");
            DomainExceptionValidation.When(dueDate < DateTime.Now, "Invalid date");
            DomainExceptionValidation.When(paymentDate < DateTime.Now, "Invalid date");

            Amount = amount;
            DueDate = dueDate;
            PaymentDate = paymentDate;
        }
    }
}
