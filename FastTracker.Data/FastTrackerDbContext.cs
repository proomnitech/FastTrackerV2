using System.Data.Entity;
using FastTracker.Data.Models;

namespace FastTracker.Data
{
    public class FastTrackerDbContext : DbContext
    {
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<InsurancePlan> InsurancePlans { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<AvailabilityType> AvailabilityTypes { get; set; }
        public DbSet<ZipGeocode> ZipGeocodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
