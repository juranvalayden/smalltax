using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class FlatRateTax : ITax
    {
        public decimal Calculate(decimal annualSalary)
        {
            return annualSalary * (17.5m/100);
        }
    }
}