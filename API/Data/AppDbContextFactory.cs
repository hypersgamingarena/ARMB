using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ARMB.API.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("Server=localhost;Database=ARMB00.0001;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
