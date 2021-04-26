using SmallTax.Data.Interfaces;

namespace SmallTax.Data.Models
{
    public class FlatValueTax : ITax
    {
        public FlatValueTax()
        {
        }

        public double Calculate(double annualSalary)
        {
            if (annualSalary > 200000)
                return 10000 + (0.5 * annualSalary);

            return 10000;
        }
    }
}