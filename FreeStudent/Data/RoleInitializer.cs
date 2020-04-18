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
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@freestudent.ru";
            string password = "_Aa123456";
            if (await roleManager.FindByNameAsync("Administrators") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Administrators"));
            }
            if (await roleManager.FindByNameAsync("employee") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("employee"));
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
        }
    }
}
