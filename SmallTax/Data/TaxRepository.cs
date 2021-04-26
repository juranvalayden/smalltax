﻿using System;
using System.Collections.Generic;
using System.Linq;
using SmallTax.Data.Entities;
using SmallTax.Data.Models;

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
    }
}