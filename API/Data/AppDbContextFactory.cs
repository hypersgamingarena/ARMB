    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ARMB.API.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // Replace YOUR_SERVER and ARMB_DB with your actual server and database name
            optionsBuilder.UseSqlServer("Server=YOUR_SERVER;Database=ARMB_DB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
