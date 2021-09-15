using System;
using Microsoft.EntityFrameworkCore;
using OurCar.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;

namespace OurCar.Database.Sql
{
    public class OurCarDbContextFactory : IDesignTimeDbContextFactory<OurCarDbContext>
    {
        public OurCarDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OurCarDbContext>();
            optionsBuilder.UseSqlServer("Server=127.0.0.1,2019;Database=OurCar;Trusted_Connection=False;MultipleActiveResultSets=true;User id=sa;Password=sa@123456");

            return new OurCarDbContext(optionsBuilder.Options);
        }
    }
}
