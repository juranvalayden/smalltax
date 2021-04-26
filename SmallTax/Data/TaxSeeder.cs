using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using SmallTax.Data.Entities;

namespace SmallTax.Data
{
    public class TaxSeeder
    {
        private readonly TaxContext _context;
        private readonly IWebHostEnvironment _environment;

        public TaxSeeder(TaxContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (!_context.TaxBrackets.Any())
            {
                var filePath = Path.Combine(_environment.ContentRootPath, "Data/tax.json");
                var json = File.ReadAllText(filePath);
                var taxBrackets = JsonSerializer.Deserialize<IEnumerable<TaxBracket>>(json);

                _context.TaxBrackets.AddRange(taxBrackets);
                _context.SaveChanges();
            }
        }
    }
}