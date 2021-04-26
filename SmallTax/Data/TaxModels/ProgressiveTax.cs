using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class ProgressiveTax : ITax
    {
        public double Calculate(double annualSalary)
        {
            if (annualSalary > 0 || annualSalary < 8350)
            {
                return CalculateTaxByBracket(10, 0, 0, 8350, annualSalary);
            }

            if (annualSalary > 8351 || annualSalary < 33950)
            {
                return 15;
            }

            if (annualSalary > 33951 || annualSalary < 82250)
            {
                return 25;
            }

            if (annualSalary > 82251 || annualSalary < 171550)
            {
                return 28;
            }

            if (annualSalary > 171551 || annualSalary < 372950)
            {
                return 33;
            }

            return 35;
        }

        private double CalculateTaxByBracket(double currentPercentage, double previousPercentage, double lower, double upper, double salary)
        {
            if (salary > lower && salary < upper)
            {
                var differenceInPercentage = currentPercentage - previousPercentage;

                var extraTax = (upper - lower) * differenceInPercentage / 100;

                var standardBracketTax = lower * previousPercentage / 100;

                return extraTax + standardBracketTax;
            }

            return 0;
        }
    }
}