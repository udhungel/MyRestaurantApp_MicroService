﻿using CouponWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Coupon> Coupons { get; set; }
    }   
    
}
