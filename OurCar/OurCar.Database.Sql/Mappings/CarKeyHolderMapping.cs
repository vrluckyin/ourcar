using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OurCar.Entity;
using OurCar.Common;

namespace OurCar.Database.Sql.Mappings
{
    public class CarKeyHolderMapping : IEntityTypeConfiguration<CarKeyHolder>
    {
        public void Configure(EntityTypeBuilder<CarKeyHolder> builder)
        {
            //builder.HasKey(b => b.Id);

            //builder.Property(b => b.Created)
            //    .IsRequired();

            //builder.Property(b => b.CreatedBy)
            //   .IsRequired();

            //builder.Property(b => b.Updated)
            //    .IsRequired();

            //builder.Property(b => b.UpdatedBy)
            //    .IsRequired();

            //builder.Property(c => c.UserId);
            //builder.Property(c => c.CarSharedId);

            builder.Property(c => c.SecurityCode)
                .IsRequired(false)
                .HasColumnType("nvarchar(10)");

            builder.Property(c => c.SecurityStatusCode)
                .IsRequired(true)
                .HasConversion(v => EnumCodes.FromRecordTypeCode(v), v => EnumCodes.GetRecordTypeCode(v))
                .HasColumnType("varchar(5)");

            //builder.HasOne(carKeyHolder => carKeyHolder.CarShared)
            //   .WithMany(carKeyHolders => carKeyHolders.CarKeyHolders)
            //   .HasForeignKey(carKeyHolder => carKeyHolder.Id)
            //   .HasConstraintName($"FK_{nameof(CarShared)}_{nameof(CarKeyHolder)}_Id");

            builder.ToTable(nameof(CarKeyHolder));
        }
    }
}
