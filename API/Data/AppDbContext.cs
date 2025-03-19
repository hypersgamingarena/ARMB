using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ARMB.Domain.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace ARMB.API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Rename DbSet to avoid conflict with Identity's Users property
        public DbSet<User> AppUsers { get; set; }
        //public DbSet<Reminder> Reminders { get; set; }
        //  public DbSet<BiographyEntry> Biographies { get; set; }

        // Fallback configuration for design-time
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=YOUR_SERVER;Database=ARMB_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }
    }
}
