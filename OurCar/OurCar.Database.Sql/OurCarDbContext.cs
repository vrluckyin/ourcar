using System;
using Microsoft.EntityFrameworkCore;
using OurCar.Entity;
using System.Linq;

namespace OurCar.Database.Sql
{
    public class OurCarDbContext : DbContext
    {
        public OurCarDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarDetail> CarDetails { get; set; }
        public virtual DbSet<LookupItem> LookupItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("nvarchar(150)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OurCarDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
