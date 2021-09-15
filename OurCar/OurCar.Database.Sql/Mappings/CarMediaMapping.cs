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
    public class CarMediaMapping : IEntityTypeConfiguration<CarMedia>
    {
        public void Configure(EntityTypeBuilder<CarMedia> builder)
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

            builder.Property(c => c.CarDetailId);
            builder.Property(c => c.MediaId);
            builder.Property(c => c.IsVideo);

            builder.HasOne(carMedia => carMedia.Media)
               .WithMany(medias => medias.CarMedias)
               .HasForeignKey(carMedia => carMedia.Id)
               .HasConstraintName($"FK_{nameof(CarMedia)}_{nameof(Media)}_Id");

            builder.ToTable(nameof(CarMedia));
        }
    }
}
