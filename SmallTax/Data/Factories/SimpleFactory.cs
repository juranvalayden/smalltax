using SmallTax.Data.Interfaces;
using SmallTax.Data.Models;
using Unity;

namespace SmallTax.Data.Factories
{
    public static class SimpleFactory
    {
        private static readonly UnityContainer PersonFactory = new UnityContainer();

        static SimpleFactory()
        {
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
