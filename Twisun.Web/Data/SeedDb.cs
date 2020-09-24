using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twisun.Common.Enums;
using Twisun.Web.Data.Entities;
using Twisun.Web.Helpers;

namespace Twisun.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext dataContext,
            IUserHelper userHelper)
        {
            _dataContext = dataContext;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckRolesAsync();
            var admin = await CheckUserAsync("111", "Calle 1", "yosorio3@eafit.edu.co", "300 000 00 00", UserType.Admin);
            var owner1 = await CheckUserAsync("222", "Calle 1", "u1twisun@mailinator.com", "300 000 00 00", UserType.User);
            var owner2 = await CheckUserAsync("333", "Calle 1", "u2twisun@mailinator.com", "300 000 00 00", UserType.User);
            var partner1 = await CheckUserAsync("444", "Calle 1", "p1twisun@mailinator.com", "300 000 00 00", UserType.Partner);
            var partner2 = await CheckUserAsync("555", "Calle 1", "p2twisun@mailinator.com", "300 000 00 00", UserType.Partner);
            await CheckOwnerAsync(admin, "Admin", "Sudo", DateTime.Now);
            var own1 = await CheckOwnerAsync(owner1, "Owner1", "Smith", DateTime.Now);
            var own2 = await CheckOwnerAsync(owner2, "Owner2", "Sherman", DateTime.Now);
            await CheckPartnerAsync(partner1, "partner1 ltda.");
            await CheckPartnerAsync(partner2, "partner2");
            await CheckCarsAsync(own1, own2);
        }

        private async Task<Owner> CheckOwnerAsync(User user, string firstName, string lastName, DateTime birthday)
        {
            var owner = new Owner
            {
                User = user,
                FirstName = firstName,
                LastName = lastName,
                Birthday = birthday
            };
            if (!_dataContext.Owners.Any())
            {               
                _dataContext.Add(owner);
                await _dataContext.SaveChangesAsync();                
            }
            return owner;
        }

        private async Task CheckPartnerAsync(User user, string name)
        {
            if (!_dataContext.Partners.Any())
            {
                _dataContext.Add(new Partner { User = user,
                                               Name = name});
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task<User> CheckUserAsync(string document, string address, string email, string phoneNumber, UserType userType)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Document = document,
                    Address = address,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phoneNumber,
                    UserType = userType
                };
                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
            return user;
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
            await _userHelper.CheckRoleAsync(UserType.Partner.ToString());
        }

        private async Task CheckCarsAsync(Owner owner1, Owner owner2)
        {
            if (_dataContext.Cars.Any())
            {
                return;
            }

            _dataContext.Cars.Add(new Car
            {
                Owner = owner1,
                Plaque = "ABC123",
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
                    //Created_at = DateTime.Now,
                    //Updated_at = DateTime.Now
                },
                Ranges = new List<Range>
                {
                    new Range
                    {
                        Value = 12,
                        //Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 15,
                        //Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 20,
                        //Created_at = DateTime.Now
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
                            //Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 60,
                            //Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 70,
                            //Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 80,
                            //Created_at = DateTime.Now
                        }
                    },
                    //Created_at = DateTime.Now,
                    //Updated_at = DateTime.Now
                },
                //Created_at = DateTime.Now
            });
            
            _dataContext.Cars.Add(new Car
            {
                Owner = owner2,
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
                    //Created_at = DateTime.Now,
                    //Updated_at = DateTime.Now
                },
                Ranges = new List<Range>
                {
                    new Range
                    {
                        Value = 12,
                        //Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 15,
                        //Created_at = DateTime.Now
                    },
                    new Range
                    {
                        Value = 20,
                        //Created_at = DateTime.Now
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
                            //Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 60,
                            //Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 70,
                            //Created_at = DateTime.Now
                        },
                        new DailySolarEnergy
                        {
                            Value = 80,
                            //Created_at = DateTime.Now
                        }
                    },
                    //Created_at = DateTime.Now,
                    //Updated_at = DateTime.Now
                },
                //Created_at = DateTime.Now
            });

            await _dataContext.SaveChangesAsync();
        }
    }
}

