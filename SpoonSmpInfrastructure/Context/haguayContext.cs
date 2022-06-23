using Microsoft.EntityFrameworkCore;
using SpoonSmpCore.Models.Database;
using SpoonSmpInfrastructure.Configurations;

#nullable disable

namespace SpoonSmpInfrastructure.Context
{
    public partial class haguayContext : DbContext
    {
        public haguayContext()
        {
        }

        public haguayContext(DbContextOptions<haguayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditEvent> AuditEvents { get; set; }
        public virtual DbSet<RegistedUser> RegistedUsers { get; set; }
        public virtual DbSet<Spaces> Spaces { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public DbSet<Reservations> reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("armscii8")
                .UseCollation("armscii8_bin");

            modelBuilder.ApplyConfiguration(new AuditEventConfiguration());
            modelBuilder.ApplyConfiguration(new RegistedUserConfiguration());
            modelBuilder.ApplyConfiguration(new SpaceConfiguration());
            modelBuilder.ApplyConfiguration(new SystemUserConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        
    }
}
