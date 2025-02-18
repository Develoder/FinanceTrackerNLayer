using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FinanceTracker.DAL
{
    public class EntitiesContext : EntitiesBaseContext
    {
        public EntitiesContext() : this(new DbContextOptions<EntitiesBaseContext>())
        {
        }

        public EntitiesContext(DbContextOptions<EntitiesBaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = GetConnectionFilePath();
            optionsBuilder.UseNpgsql(connectionString);
        }

        public static string GetConnectionFilePath()
        {
            string fullName = Directory.GetCurrentDirectory();
            var config = new ConfigurationBuilder()
                .SetBasePath(fullName)
                .AddJsonFile("connectionsetting.json")
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            return connectionString;
        }
    }
}
