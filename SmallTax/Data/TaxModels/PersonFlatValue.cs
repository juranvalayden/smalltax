using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class PersonFlatValue : PersonProgressiveTax
    {
        public override ITax CreateTax()
        {
            return new FlatValueTax();
        }
    }
}