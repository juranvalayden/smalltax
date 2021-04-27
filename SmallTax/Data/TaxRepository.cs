using System;
using System.Collections.Generic;
using System.Linq;
using SmallTax.Data.Entities;

namespace SmallTax.Data
{
    public class TaxRepository : ITaxRepository
    {
        private readonly TaxContext _context;

        public TaxRepository(TaxContext context)
        {
            _context = context;
        }

        public IEnumerable<TaxBracket> GetAllTaxBrackets()
        {
            try
            {
                return _context.TaxBrackets.ToList();
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"{ex.Message}");
            }
        }

        public void AddEntity(object entity)
        {
            _context.Add(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}