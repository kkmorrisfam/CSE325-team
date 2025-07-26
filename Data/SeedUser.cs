using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace CSE325_team.Data
{
    public static class SeedUser
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();


            string[] roles = new[] { "Admin", "User", "Agent" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }


            //Create default Admin user, if it's not already there
            string adminEmail = "admin@bookme.com";
            string adminPassword = "Admin123!";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                var admin = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName = "Bob",
                    LastName = "Smith"
                };


                var result = await userManager.CreateAsync(admin, adminPassword);
                if (result.Succeeded)
                {
                    //inserts "Admin" role into AspNetRoles table
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
                else
                {
                    throw new Exception($"Failed to create admin user: {string.Join(", ", result.Errors)}");
                }
            }

            // Create Agent user
            string agentEmail = "agent@bookme.com";
            string agentPassword = "Agent123!";
            var agentUser = await userManager.FindByEmailAsync(agentEmail);
            // if there's no agentUser yet, create one
            if (agentUser == null)
            {
                var agent = new ApplicationUser
                {
                    UserName = agentEmail,
                    Email = agentEmail,
                    EmailConfirmed = true,
                    FirstName = "Alex",
                    LastName = "Johnson"
                };
                // create the agent user and add to the "Agent" role
                var result = await userManager.CreateAsync(agent, agentPassword);
                if (result.Succeeded)
                {
                    //inserts "Agent" role into AspNetRoles table
                    await userManager.AddToRoleAsync(agent, "Agent");
                }
                else
                {
                    throw new Exception($"Failed to create agent user: {string.Join(", ", result.Errors)}");
                }

            }

            //Create regular "User"
            string userEmail = "user@gmail.com";
            string userPassword = "User123!";
            var normalUser = await userManager.FindByEmailAsync(userEmail);
            // if normalUser is not there, create it
            if (normalUser == null)
            {
                var newUser = new ApplicationUser
                {
                    UserName = userEmail,
                    Email = userEmail,
                    EmailConfirmed = true,
                    FirstName = "Sarah",
                    LastName = "Hale"
                };

                var result = await userManager.CreateAsync(newUser, userPassword);
                if (result.Succeeded)
                {
                    //inserts "User" role into AspNetRoles table
                    await userManager.AddToRoleAsync(newUser, "User");
                }
                else
                {
                    throw new Exception($"Failed to create regular user: {string.Join(", ", result.Errors)}");
                }

            }
        }
    }
}