using System;
using Microsoft.EntityFrameworkCore;

namespace ExerciceConnectLime.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<SingularPerson> SingularPersons { get; set; } = null!;
        // public DbSet<Purchase> Purchases { get; set; } = null!;
        // public DbSet<Selling> Sellings { get; set; } = null!;
        // public DbSet<Product> Products { get; set; } = null!;

    }
}
