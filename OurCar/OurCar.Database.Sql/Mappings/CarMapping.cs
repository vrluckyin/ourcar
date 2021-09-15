using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OurCar.Entity;

namespace OurCar.Database.Sql.Mappings
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Created)
                .IsRequired();

            builder.Property(b => b.CreatedBy)
               .IsRequired();

            builder.Property(b => b.Updated)
                .IsRequired();

            builder.Property(b => b.UpdatedBy)
                .IsRequired();

            builder.HasMany(c => c.CarDetails)
                .WithOne(b => b.Car)
                .HasForeignKey(b => b.CarId);

            builder.HasOne(car => car.CarType)
                .WithMany(lookup => lookup.Cars)
                .HasForeignKey(car => car.Id)
                .HasConstraintName("FK_Car_LookupItem_CarType_Id");

            builder.ToTable(nameof(Car));
        }
    }
}
