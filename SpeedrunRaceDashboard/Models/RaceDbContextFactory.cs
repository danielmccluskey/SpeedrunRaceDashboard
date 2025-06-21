using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SpeedrunRaceDashboard.Models
{
    public class RaceDbContextFactory : IDesignTimeDbContextFactory<RaceDbContext>
    {
        public RaceDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RaceDbContext>();
            var dbPath = Path.Combine(AppContext.BaseDirectory, "race.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath};Mode=ReadWriteCreate;Cache=Shared");


            return new RaceDbContext(optionsBuilder.Options);
        }
    }
}
