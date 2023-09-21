using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ButcherDatabase : DbContext
    {
        public ButcherDatabase(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Farmer>()
                .HasBaseType<Person>();

            modelBuilder.Entity<Butcher>()
                .HasBaseType<Person>();
            modelBuilder.Entity<Animal>()
                .ToTable("Animals");

        }
        public  DbSet<Farmer> Farmers { get; set; }
        public DbSet<Butcher> Butchers { get; set; }
        public DbSet<Animal> Animals { get; set; }

    }
}