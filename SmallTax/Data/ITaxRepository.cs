using System.Collections.Generic;
using SmallTax.Data.Entities;

namespace SmallTax.Data
{
    public interface ITaxRepository
    {
        IEnumerable<TaxBracket> GetAllTaxBrackets();
        bool SaveAll();
    }
}