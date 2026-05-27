using NoticeBoardApi.Models;
using BCrypt.Net;

namespace NoticeBoardApi.Data
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
 
        { 


            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Username = "admin",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                        Role = "Admin"
                    },
                    new User
                    {
                        Username = "viewer",
                        PasswordHash = BCrypt.Net.BCrypt.HashPassword("Viewer@123"),
                        Role = "Viewer"
                    }
                );
                context.SaveChanges();
            }


        }
} 
} 
