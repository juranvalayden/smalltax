namespace SmallTax.Data.Interfaces
{
    public interface IPersonFactory
    {
        ITax CreateTax();
        IPerson CreatePerson(IPerson person);
    }
}