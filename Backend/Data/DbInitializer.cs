using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class DbInitializer
    {
        public static async Task InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>()
            ?? throw new InvalidOperationException("Failed to retrieve store context");
            //section 9 add them userManager thi config them
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>()
             ?? throw new InvalidOperationException("Failed to retrieve user manager");

            await SeedData(context, userManager);
        }

        private static async Task SeedData(AppDbContext context, UserManager<User> userManager)
        {

            context.Database.Migrate();
            var user = new User
            {
                UserName = "bob@test.com",
                Email = "bob@test.com",

            };
            // complex pass 
            await userManager.CreateAsync(user, "Pa$$w0rd");
            await userManager.AddToRoleAsync(user, "Member");

            var admin = new User
            {
                UserName = "admin@test.com",
                Email = "admin@test.com",

            };
            // complex pass 
            await userManager.CreateAsync(admin, "Pa$$w0rd");
            await userManager.AddToRolesAsync(admin, ["Admin", "Member"]);
            context.SaveChanges();
        }
    
    }
}

