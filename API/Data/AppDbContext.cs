using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ARMB.Domain.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace ARMB.API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Parameterless constructor (if needed for design-time)
        public AppDbContext() { }

        // Rename to avoid conflict with Identity's built-in Users property
        public DbSet<Domain.Entities.User> AppUsers { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        
        public DbSet<BiographyEntry> Biographies { get; set; }

        // Optional: Fallback configuration for design-time migrations
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Replace with your actual connection string
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ARMB_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }
    }
}
