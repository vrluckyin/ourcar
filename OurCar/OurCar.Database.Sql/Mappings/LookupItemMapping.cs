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
    public class LookupItemMapping : IEntityTypeConfiguration<LookupItem>
    {
        public void Configure(EntityTypeBuilder<LookupItem> builder)
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

            builder.Property(c => c.ItemGroup)
                .IsRequired(false)
                .HasColumnType("nvarchar(100)");

            builder.Property(c => c.ItemCode)
                .IsRequired(false)
                .HasColumnType("nvarchar(100)");

            builder.Property(c => c.ItemDescription)
                .IsRequired(false)
                .HasColumnType("nvarchar(200)");

            builder.ToTable(nameof(LookupItem));
        }
    }
}
