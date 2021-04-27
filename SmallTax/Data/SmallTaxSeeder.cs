using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using SmallTax.Data.Entities;
using SmallTax.Data.Interfaces;
using SmallTax.Data.TaxModels;

namespace SmallTax.Data
{
    public class SmallTaxSeeder
    {
        private readonly SmallTaxContext _context;
        private readonly IWebHostEnvironment _environment;

        public SmallTaxSeeder(SmallTaxContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (!_context.TaxBrackets.Any() || !_context.Persons.Any())
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "Data/tax.json");
                var json = File.ReadAllText(filePath);
                var taxBrackets = JsonSerializer.Deserialize<IEnumerable<TaxBracket>>(json);
                _context.TaxBrackets.AddRange(taxBrackets);

                var person = new Person(new FlatRateTax());
                _context.Add(person);

                _context.SaveChanges();
            }
        }
    }
}