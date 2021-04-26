using SmallTax.Data.Interfaces;

namespace SmallTax.Data.Entities
{
    public class Person : IPerson
    {
        private readonly ITax _tax;
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public double AnnualSalary { get; set; }

        public Person(ITax tax)
        {
            _tax = tax;
        }

        public virtual double TotalTax()
        {
            return AnnualSalary - _tax.Calculate(AnnualSalary);
        }
    }
}
