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

            PersonFactory.RegisterType<ITax, ProgressiveTax>("7441");
            PersonFactory.RegisterType<ITax, ProgressiveTax>("1000");
            PersonFactory.RegisterType<ITax, FlatValueTax>("A100");
            PersonFactory.RegisterType<ITax, FlatRateTax>("7000");
        }

        public static IPerson CreatePerson(string postalCode)
        {
            return PersonFactory.Resolve<IPersonFactory>(postalCode).CreatePerson();
        }
    }
}
