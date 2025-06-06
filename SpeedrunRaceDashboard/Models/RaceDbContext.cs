using Microsoft.EntityFrameworkCore;

namespace SpeedrunRaceDashboard.Models
{
    public class RaceDbContext : DbContext
    {
        public RaceDbContext(DbContextOptions<RaceDbContext> options)
            : base(options) { }
        public DbSet<StreamSlot> StreamSlots { get; set; }
        public DbSet<StreamProfile> StreamProfiles { get; set; }
        public DbSet<StreamSettings> StreamSettings { get; set; }
    }
}
