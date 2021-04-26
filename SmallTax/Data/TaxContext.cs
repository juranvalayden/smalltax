using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmallTax.Data.Entities;
using SmallTax.Data.Models;

namespace SmallTax.Data
{
    public class TaxContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public TaxContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<TaxBracket> TaxBrackets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("TaxConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaxBracket>();
        }
    }
}