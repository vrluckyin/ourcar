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
    public class SubscriptionCarSharedMapping : IEntityTypeConfiguration<SubscriptionCarShared>
    {
        public void Configure(EntityTypeBuilder<SubscriptionCarShared> builder)
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

            builder.Property(c => c.StatusCode)
               .IsRequired(true)
               .HasConversion(v => EnumCodes.FromRecordTypeCode(v), v => EnumCodes.GetRecordTypeCode(v))
               .HasColumnType("varchar(5)");

            builder.ToTable(nameof(SubscriptionCarShared));
        }
    }
}
