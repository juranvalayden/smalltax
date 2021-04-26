using System;
using SmallTax.Data.Interfaces;

namespace SmallTax.Data.Entities
{
    public class Person : IPerson
    {
        private readonly ITax _tax;
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public decimal AnnualSalary { get; set; }
        public DateTime CreatedDate { get; set; }

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
