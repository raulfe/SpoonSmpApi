using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpoonSmpCore.Models.Database;

namespace SpoonSmpInfrastructure.Configurations
{
    public class SpaceConfiguration : IEntityTypeConfiguration<Spaces>
    {
        public void Configure(EntityTypeBuilder<Spaces> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("spaces");

            builder.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("CREATED_BY");

            builder.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_DATE");

            builder.Property(e => e.MorningAvailable)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("MORNING_AVAILABLE")
                .HasDefaultValueSql("'Y'");

            builder.Property(e => e.MorningReservationCode)
                .HasMaxLength(250)
                .HasColumnName("MORNING_RESERVATION_CODE");

            builder.Property(e => e.NightAvailable)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("NIGHT_AVAILABLE")
                .HasDefaultValueSql("'Y'");

            builder.Property(e => e.NightReservationCode)
                .HasMaxLength(250)
                .HasColumnName("NIGHT_RESERVATION_CODE");

            builder.Property(e => e.SpaceName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("SPACE_NAME");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");

            builder.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("UPDATED_BY");
        }
    }
}
