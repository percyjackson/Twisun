using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Twisun.Web.Data.Entities;

namespace Twisun.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<DailySolarEnergy> DailySolarEnergies { get; set; }
        public DbSet<Range> Ranges { get; set; }
        public DbSet<SolarPanel> SolarPanels { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<UsedCoupon> UsedCoupons { get; set; }
        public DbSet<Point> Points { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Car>()
                .HasIndex(t => t.Plaque)
                .IsUnique();
        }
    }
}
