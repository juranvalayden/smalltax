using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class FlatRateTax : ITax
    {
        public double Calculate(double annualSalary)
        {
            return 17.5;
        }
    }
}