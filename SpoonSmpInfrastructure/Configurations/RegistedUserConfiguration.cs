using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpoonSmpCore.Models.Database;

namespace SpoonSmpInfrastructure.Configurations
{
    public class RegistedUserConfiguration : IEntityTypeConfiguration<RegistedUser>
    {
        public void Configure(EntityTypeBuilder<RegistedUser> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("registed_users");

            builder.HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("CREATED_BY");

            builder.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_DATE")
                .HasDefaultValueSql("curdate()");

            builder.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");

            builder.Property(e => e.ReservationCode)
                .HasMaxLength(250)
                .HasColumnName("RESERVATION_CODE");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");

            builder.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("UPDATED_BY");

            builder.Property(e => e.Id)
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

            builder.Property(e => e.UserLastName)
                .HasMaxLength(100)
                .HasColumnName("USER_LAST_NAME");

            builder.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("USER_NAME");

            builder.Property(e => e.UserPhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("USER_PHONE_NUMBER");
        }
    }
}
