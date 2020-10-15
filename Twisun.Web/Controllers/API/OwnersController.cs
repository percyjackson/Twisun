using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Twisun.Common.Models;
using Twisun.Web.Data;
using Twisun.Web.Data.Entities;

namespace Twisun.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OwnersController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OwnersController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpPost]
        [Route("GetOwnerByEmail")]
        public async Task<IActionResult> GetOwner(EmailRequest emailRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Owner owner = await _dataContext.Owners
                .Include(o => o.User)
                .Include(o => o.UsedCoupons)
                .ThenInclude(c => c.Coupon)
                .ThenInclude(p => p.Partner)
                .Include(c => c.Cars)
                .ThenInclude(b => b.Battery)
                .Include(c => c.Cars)
                .ThenInclude(r => r.Ranges)
                .Include(c => c.Cars)
                .ThenInclude(s => s.SolarPanel)
                .ThenInclude(d => d.DailySolarEnergies)
                .FirstOrDefaultAsync(o => o.User.UserName.ToLower() == emailRequest.Email.ToLower());

            OwnerResponse response = new OwnerResponse
            {
                Id = owner.Id,
                Address = owner.User.Address,
                Age = owner.Age.GetValueOrDefault(),
                Birthday = owner.Birthday,
                Document = owner.User.Document,
                Email = owner.User.Email,
                FirstName = owner.FirstName,
                Gender = owner.Gender.GetValueOrDefault(),
                LastName = owner.LastName,
                PicturePath = owner.User.PicturePath,
                TotalPoints = owner.TotalPoints.GetValueOrDefault(),
                PhoneNumber = owner.User.PhoneNumber,
                UsedCoupons = owner.UsedCoupons.Select(u => new UsedCouponResponse
                {
                    Id = u.Id,
                    CreatedAt = u.CreatedAt,
                    Coupon = new CouponResponse
                    {
                        Id = u.Coupon.Id,
                        Description = u.Coupon.Description,
                        Cost = u.Coupon.Cost,
                        Partner = u.Coupon.Partner.Name
                    }
                }).ToList(),
                Cars = owner.Cars.Select(c => new CarResponse
                {
                    Id = c.Id,
                    ChargedBatteries = c.ChargedBatteries.GetValueOrDefault(),
                    Model = c.Model,
                    Plaque = c.Plaque,
                    SolarKm = c.SolarKm.GetValueOrDefault(),
                    TotalKm = c.TotalKm.GetValueOrDefault(),
                    Battery = new BatteryResponse
                    {
                        Id = c.Battery.Id,
                        Capacity = c.Battery.Capacity,
                        OutletLevel = c.Battery.OutletLevel,
                        SolarLevel = c.Battery.SolarLevel,
                        StateOfCharge = c.Battery.StateOfCharge,
                        StateOfHealth = c.Battery.StateOfHealth
                    },
                    Ranges = c.Ranges.Select(r => new RangeResponse
                    {
                        Id = r.Id,
                        CreatedAt = r.CreatedAt,
                        Value = r.Value
                    }).Where(r => DateTime.Compare(r.CreatedAt, DateTime.Today.AddMonths(-3))>=0).ToList(),
                    SolarPanel = new SolarPanelResponse
                    {
                        Id = c.SolarPanel.Id,
                        Serial = c.SolarPanel.Serial,
                        Cells = c.SolarPanel.Cells,
                        EstimatedEfficiency = c.SolarPanel.EstimatedEfficiency,
                        FoldedArea = c.SolarPanel.FoldedArea,
                        UnfoldedArea = c.SolarPanel.UnfoldedArea,
                        DailySolarEnergies = c.SolarPanel.DailySolarEnergies.Select(d => new DailySolarEnergyResponse
                        {
                            Id = d.Id,
                            CreatedAt = d.CreatedAt,
                            Value = d.Value
                        }).Where(d => DateTime.Compare(d.CreatedAt, DateTime.Today.AddMonths(-3)) >= 0).ToList()
                    }
                }).ToList()
            };
            if (owner == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}