using SmallTax.Data.Entities;
using SmallTax.Data.Interfaces;
using SmallTax.Data.TaxModels;

namespace SmallTax.Data.Factories
{
    public class PersonFactory : IPersonFactory
    {
        public virtual ITax CreateTax()
        {
            return new FlatRateTax();
        }

        public virtual IPerson CreatePerson()
        {
            return new Person(CreateTax());
        }
    }
}
