using ProjetoIntegradorII.Domain.Validations;

namespace ProjetoIntegradorII.Domain.Entities
{
    public sealed class Beneficiary : Entity
    {
        public string Name { get; private set; }
        public int LegalNature { get; private set; }
        public string Phone { get; private set; }
        public bool Active { get; private set; }
        public int AdressId { get; set; }
        public Adress Adress { get; set; }

        public Beneficiary(string name, int legalNature, string phone)
        {
            ValidateDomain(name, legalNature, phone);
        }

        public Beneficiary(string name, int legalNature, string Phone, int adressId)
        {
            ValidateDomain(name, legalNature, Phone);
            AdressId = adressId;
        }

        public void ValidateDomain(string name, int legalNature, string phone)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Minimum 3 chars");
            DomainExceptionValidation.When(legalNature < 0, "Invalid legal nature. Should be greater than 0");
            DomainExceptionValidation.When(phone.Length < 9, "Invalid phone. Mininum of 9 chars");

            Name = name;
            LegalNature = legalNature;
            Phone = phone;
        }
    }
}
