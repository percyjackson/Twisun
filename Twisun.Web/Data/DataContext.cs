using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twisun.Web.Data.Entities;

namespace Twisun.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<DailySolarEnergy> DailySolarEnergies { get; set; }
        public DbSet<Range> Ranges { get; set; }
        public DbSet<SolarPanel> SolarPanels { get; set; }
    }
}
