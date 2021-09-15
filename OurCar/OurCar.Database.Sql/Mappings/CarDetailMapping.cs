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
    public class CarDetailMapping : IEntityTypeConfiguration<CarDetail>
    {
        public void Configure(EntityTypeBuilder<CarDetail> builder)
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

            builder.Property(b => b.SafetyDetail)
                .IsRequired(false)
                .HasColumnType("nvarchar(max)"); ;

            builder.HasOne(car => car.InsuranceType)
                .WithMany(lookup => lookup.CarDetails)
                .HasForeignKey(carDetail => carDetail.Id)
                .HasConstraintName("FK_CarDetail_LookupItem_InsuranceType_Id");

            builder.ToTable(nameof(CarDetail));
        }
    }
}
