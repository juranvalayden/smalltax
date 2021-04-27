using SmallTax.Data.Entities;
using SmallTax.Data.Interfaces;
using SmallTax.Data.TaxModels;
using Unity;

namespace SmallTax.Data.Factories
{
    public static class SimpleFactory
    {
        private static readonly UnityContainer PersonFactory;

        static SimpleFactory()
        {
            PersonFactory = new UnityContainer();

            PersonFactory.RegisterType<IPersonFactory, PersonProgressiveTax>("7441");
            PersonFactory.RegisterType<IPersonFactory, PersonProgressiveTax>("1000");
            PersonFactory.RegisterType<IPersonFactory, PersonFlatValue>("A100");
            PersonFactory.RegisterType<IPersonFactory, PersonFlatRate>("7000");
        }

        public static IPerson CreatePerson(IPerson person)
        {
            return PersonFactory.Resolve<IPersonFactory>(person.PostalCode).CreatePerson(person);
        }
    }
}
