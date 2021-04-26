using System.Collections.Generic;
using SmallTax.Data.Entities;
using SmallTax.Data.Models;

namespace SmallTax.Data
{
    public interface ITaxRepository
    {
        IEnumerable<TaxBracket> GetAllTaxBrackets();
    }
}