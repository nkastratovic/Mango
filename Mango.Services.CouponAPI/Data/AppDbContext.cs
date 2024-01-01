using Microsoft.EntityFrameworkCore;
using Mango.Services.CouponAPI.Models;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Coupon> Coupons { get; set; }
    }
}
