using SmallTax.Data.Interfaces;

namespace SmallTax.Data.Models
{
    public class FlatRateTax : ITax
    {
        public double Calculate(double annualSalary)
        {
            return 17.5;
        }
    }
}