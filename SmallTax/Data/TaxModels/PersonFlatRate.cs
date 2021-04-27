using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class PersonFlatRate : PersonProgressiveTax
    {
        public override ITax CreateTax()
        {
            return new FlatRateTax();
        }
    }
}