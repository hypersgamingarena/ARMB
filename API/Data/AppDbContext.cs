using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ARMB.Domain.Entities;

namespace ARMB.API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Rename your Users DbSet to avoid conflict with Identity's Users property
        public DbSet<User> AppUsers { get; set; }// error at user
        public DbSet<Reminder> Reminders { get; set; } //error at reminder
       public DbSet<BiographyEntry> Biographies { get; set; } //error at biographyentry
    }
}
