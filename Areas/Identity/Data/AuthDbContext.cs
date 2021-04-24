using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiLam.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BaiLam.Seeds;


namespace BaiLam.Data
{
    public class AuthDbContext : IdentityDbContext<AdminUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            AdminUser appUser = new AdminUser
            {
                UserName = "tester",
                Email = "Admin_1@gmail.com",
                NormalizedEmail = "Admin_1@gmail.com".ToUpper(),
                NormalizedUserName = "Admin_1@gmail.com".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                AccessFailedCount=0,
                LockoutEnabled=false,               
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<AdminUser> ph = new PasswordHasher<AdminUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Admin_1");

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            );
            builder.Entity<AdminUser>().HasData(
                appUser
            );

        }
    }
}
