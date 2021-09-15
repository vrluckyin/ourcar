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
    public class SubscriptionPaymentMapping : IEntityTypeConfiguration<SubscriptionPayment>
    {
        public void Configure(EntityTypeBuilder<SubscriptionPayment> builder)
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

            builder.ToTable(nameof(SubscriptionPayment));
        }
    }
}
