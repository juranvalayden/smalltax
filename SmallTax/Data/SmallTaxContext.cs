using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmallTax.Data.Entities;

namespace SmallTax.Data
{
    public class SmallTaxContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<TaxBracket> TaxBrackets { get; set; }

        private readonly IConfiguration _configuration;

        public SmallTaxContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:SmallTaxContextDb"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaxBracket>();
            modelBuilder.Entity<Person>();
        }
    }
}