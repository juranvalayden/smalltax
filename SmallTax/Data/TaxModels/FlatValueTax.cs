using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class FlatValueTax : ITax
    {
        public FlatValueTax()
        {
        }

        public decimal Calculate(decimal annualSalary)
        {
            if (annualSalary > 200000)
                return 10000 + (0.5m * annualSalary);

            return 10000;
        }
    }
}