using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpoonSmpCore.Models.Database;

namespace SpoonSmpInfrastructure.Configurations
{
    public class AuditEventConfiguration : IEntityTypeConfiguration<AuditEvent>
    {
        public void Configure(EntityTypeBuilder<AuditEvent> builder)
        {
            builder.HasKey(e => e.UniqId)
                    .HasName("PRIMARY");

            builder.ToTable("audit_events");

            builder.HasComment("Table to audit events")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            builder.HasIndex(e => e.UniqId, "AUDIT_PK")
                .IsUnique();

            builder.Property(e => e.UniqId)
                .HasColumnType("int(11)")
                .HasColumnName("UNIQ_ID");

            builder.Property(e => e.AuditType)
                .HasMaxLength(25)
                .HasColumnName("AUDIT_TYPE");

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(250)
                .HasColumnName("CREATED_BY");

            builder.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_DATE")
                .HasDefaultValueSql("curdate()");

            builder.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("DESCRIPTION");

            builder.Property(e => e.Pkey)
                .HasMaxLength(150)
                .HasColumnName("PKEY");

            builder.Property(e => e.TableName)
                .HasMaxLength(30)
                .HasColumnName("TABLE_NAME");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");

            builder.Property(e => e.UpdatedBy)
                .HasMaxLength(250)
                .HasColumnName("UPDATED_BY");

            builder.Property(e => e.Xdate)
                .HasColumnType("datetime")
                .HasColumnName("XDATE");

            builder.Property(e => e.Xuser)
                .HasMaxLength(30)
                .HasColumnName("XUSER");
        }
    }
}
