using System.Security.Claims;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
        context.Database.EnsureCreated(); // Creates the database if not exists

        // Fetch all roles
        var roles = await context.Roles.ToListAsync();

        // For each role, add a claim for each user associated with the role
        foreach (var role in roles)
        {
            var usersInRole = await userManager.GetUsersInRoleAsync(role.Name);
            foreach (var user in usersInRole)
            {
                // Check if the user already has this claim
                var userClaims = await userManager.GetClaimsAsync(user);
                if (!userClaims.Any(c => c.Type == ClaimTypes.Role && c.Value == role.Name))
                {
                    // Add claim to user
                    await userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, role.Name));
                }
            }
        }
    }
}