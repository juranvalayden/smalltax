using System.Collections.Generic;
using SmallTax.Data.Entities;

namespace SmallTax.Data
{
    public interface ISmallTaxRepository
    {
        IEnumerable<TaxBracket> GetAllTaxBrackets();
        void AddEntity(object entity);
        bool SaveAll();
    }
}