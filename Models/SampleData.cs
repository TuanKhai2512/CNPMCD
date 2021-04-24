using BaiLam.Areas.Identity.Data;
using BaiLam.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Models
{
    public class SampleData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<AuthDbContext>();

            string[] roles = new string[] { "Admin" };

            foreach (string role in roles)
            {
                var roleStore = new RoleStore<IdentityRole>(context);

                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.CreateAsync(new IdentityRole(role));
                }
            }


            var user = new AdminUser
            {
                Email = "Admin1@gmail.com",
                NormalizedEmail = "Admin1@gmail.com",
                UserName = "Admin",
                NormalizedUserName = "Admin",
                PhoneNumber = "+840705167772",
                EmailConfirmed = true,
                AccessFailedCount = 0,
                LockoutEnabled = false,
                TwoFactorEnabled = false,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };


            if (!context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<AdminUser>();
                var hashed = password.HashPassword(user, "Admin_1");
                user.PasswordHash = hashed;

                var userStore = new UserStore<AdminUser>(context);
                var result = userStore.CreateAsync(user);

            }

            AssignRoles(serviceProvider, user.Email, roles);

            context.SaveChangesAsync();
        }

        public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string[] roles)
        {
            UserManager<AdminUser> _userManager = services.GetService<UserManager<AdminUser>>();
            AdminUser user = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.AddToRolesAsync(user, roles);

            return result;
        }
    }

}
