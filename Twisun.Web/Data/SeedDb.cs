using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twisun.Web.Data.Entities;

namespace Twisun.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckCarsAsync();
        }

        private async Task CheckCarsAsync()
        {
            if (_dataContext.Cars.Any())
            {
                return;
            }

            _dataContext.Cars.Add(new Car
            {
                Plaque = "ABC123",
                Model = 2020,
                ChargedBatteries = 0,
                SolarKm = 0,
                TotalKm = 0,
                Battery =  new Battery
                {
                    OutletLevel = 0,
                    StateOfCharge = 50,
                    SolarLevel = 20,
                    StateOfHealth = 98,
                    Capacity = 70,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now
                },
                Ranges = new List<Range>
                {
                    new Range
                    {
                        Value = 12,
                        Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 15,
                        Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 20,
                        Created_at = DateTime.Now
                    }
                },
                SolarPanel = new SolarPanel
                {
                    Serial = "123456",
                    Cells = 50,
                    EstimatedEfficiency = 70,
                    FoldedArea = 45,
                    UnfoldedArea = 70,
                    DailySolarEnergies = new List<DailySolarEnergy>
                    {
                        new DailySolarEnergy
                        {
                            Value = 50,
                            Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 60,
                            Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 70,
                            Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 80,
                            Created_at = DateTime.Now
                        }
                    },
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now
                },
                Created_at = DateTime.Now,
                Updated_at = DateTime.Now
            });

            _dataContext.Cars.Add(new Car
            {
                Plaque = "ABC222",
                Model = 2020,
                ChargedBatteries = 0,
                SolarKm = 0,
                TotalKm = 0,
                Battery = new Battery
                {
                    OutletLevel = 0,
                    StateOfCharge = 50,
                    SolarLevel = 20,
                    StateOfHealth = 98,
                    Capacity = 70,
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now
                },
                Ranges = new List<Range>
                {
                    new Range
                    {
                        Value = 12,
                        Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 15,
                        Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 20,
                        Created_at = DateTime.Now
                    }
                },
                SolarPanel = new SolarPanel
                {
                    Serial = "1234567",
                    Cells = 50,
                    EstimatedEfficiency = 70,
                    FoldedArea = 45,
                    UnfoldedArea = 70,
                    DailySolarEnergies = new List<DailySolarEnergy>
                    {
                        new DailySolarEnergy
                        {
                            Value = 50,
                            Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 60,
                            Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 70,
                            Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 80,
                            Created_at = DateTime.Now
                        }
                    },
                    Created_at = DateTime.Now,
                    Updated_at = DateTime.Now
                },
                Created_at = DateTime.Now,
                Updated_at = DateTime.Now
            });

            await _dataContext.SaveChangesAsync();
        }
    }
}
