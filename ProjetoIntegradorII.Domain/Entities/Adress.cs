using ProjetoIntegradorII.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoIntegradorII.Domain.Entities
{
    public sealed class Adress : Entity
    {
        public string Street { get; private set; }
        public string City { get; private set; }    
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public string AdressNumber { get; private set; }
        public string State { get; private set; }
        
        public ICollection<Beneficiary> Beneficiaries { get;  set; }

        public Adress(int id, string street, string city, string postalCode, string country, string adressNumber, string state) 
        {
            ValidateDomain(street, city, postalCode, country, adressNumber, state);
            DomainExceptionValidation.When(id < 0, "Invalid id value");
        }

        public void ValidateDomain(string street, string city, string postalCode, string country, string adressNumber, string state)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(street), "Invalid street. Street is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(city), "Invalid city. city is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(postalCode), "Invalid postal code. Postal code is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(country), "Invalid country. Country is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(adressNumber), "Invalid adress number. Adress number is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(state), "Invalid state. State is required");
            DomainExceptionValidation.When(street.Length < 3, "Invalid street. Minimum 3 chars");
            DomainExceptionValidation.When(city.Length < 3, "Invalid city. Minimum 3 chars");
            DomainExceptionValidation.When(postalCode.Length != 8, "Invalid post code. Should be 8 chars");
            DomainExceptionValidation.When(country.Length < 3, "Invalid country. Minimum 3 chars");
            DomainExceptionValidation.When(state.Length < 2, "Invalid state. Minimum 2 chars");

            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
            AdressNumber = adressNumber;
            State = state;
        }

    }
}
