using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OurCar.Common;
using OurCar.Entity;

namespace OurCar.Database.Sql.Mappings
{
    public class CarSharedMapping : IEntityTypeConfiguration<CarShared>
    {
        public void Configure(EntityTypeBuilder<CarShared> builder)
        {
            builder.HasKey(b => b.Id);

            //builder.Property(b => b.Created)
            //    .IsRequired();

            //builder.Property(b => b.CreatedBy)
            //   .IsRequired();

            //builder.Property(b => b.Updated)
            //    .IsRequired();

            //builder.Property(b => b.UpdatedBy)
            //    .IsRequired();

            //builder.Property(c => c.CarDetailId);
            //builder.Property(c => c.Expiration);
            //builder.Property(c => c.CurrentKeyHolderUserId);
            //builder.Property(c => c.UpdateStatusUserId);
            //builder.Property(c => c.LimitedToPeople);

            builder.Property(c => c.Title)
                .IsRequired(false)
                .HasColumnType("nvarchar(200)");

            builder.Property(c => c.Description)
                .IsRequired(false)
                .HasColumnType("nvarchar(2000)");

            builder.Property(c => c.StatusCode)
                .IsRequired(true)
                .HasConversion(v => EnumCodes.FromRecordTypeCode(v), v => EnumCodes.GetRecordTypeCode(v))
                .HasColumnType("varchar(5)");

            builder.ToTable(nameof(CarShared));
        }
    }
}
