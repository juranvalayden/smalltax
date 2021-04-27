using SmallTax.Data.Entities;
using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class PersonProgressiveTax : IPersonFactory
    {
        public virtual ITax CreateTax()
        {
            return new ProgressiveTax();
        }

        public virtual IPerson CreatePerson(IPerson person)
        { 
            return new Person(CreateTax(), person); 
        }
    }
}
