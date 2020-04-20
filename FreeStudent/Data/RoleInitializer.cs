using FreeStudent.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, AppDbContext _context)
        {
            string adminEmail = "admin@freestudent.ru";
            string password = "_Aa123456";
            if (await roleManager.FindByNameAsync("Administrators") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Administrators"));
            }
            if (await roleManager.FindByNameAsync("Manager") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Manager"));
            }
            if (await roleManager.FindByNameAsync("Executor") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Executor"));
            }
            if (await roleManager.FindByNameAsync("Customer") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                admin.EmailConfirmed = true;
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Administrators");
                }
            }
            if (!_context.Tariffs.Any())
            {
                _context.Tariffs.Add(new Tariff { Name = "Новый тариф"});
                _context.SaveChanges();
            }

        }
    }
}
