using System;
using SmallTax.Data.Interfaces;

namespace SmallTax.Data.Entities
{
    public class Person : IPerson
    {
        private readonly ITax _tax;
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public decimal AnnualSalary { get; set; }
        public DateTime CreatedDate { get; set; }

        public Person() { }

        public Person(ITax tax, IPerson person)
        {
            _tax = tax;
            Name = person.Name;
            PostalCode = person.PostalCode;
            AnnualSalary = person.AnnualSalary;
        }

        public Person(ITax tax)
        {
            _tax = tax;
        }

        public virtual decimal TotalTax()
        {
            return AnnualSalary - _tax.Calculate(AnnualSalary);
        }
    }
}
