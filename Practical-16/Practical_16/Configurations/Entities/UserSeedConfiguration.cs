using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practical_16.Data;

namespace Practical_16.Configuartions.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User_Admin>
    {
       

        public void Configure(EntityTypeBuilder<User_Admin> builder)
        {
            var hasher = new PasswordHasher<User_Admin>();
            builder.HasData(
                new User_Admin
                {
                    Id = "5b2546a3-3e7a-454e-ac18-52d4cae97b2f",
                    Email = "User@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    NormalizedUserName = "USER@GMAIL.COM",
                    UserName = "User@gmail.com",
                    FirstName = "User",
                    LastName = "user",
                    PasswordHash = hasher.HashPassword(null, "User@123"),
                    EmailConfirmed = true
                },
                new User_Admin
                {
                    Id = "4b2546a3-3e7a-424e-ac18-52d4cae97b2f",
                    Email = "student@gmail.com",
                    NormalizedEmail = "student@GMAIL.COM",
                    NormalizedUserName = "STUDENT@GMAIL.COM",
                    UserName = "student@gmail.com",
                    FirstName = "Student",
                    LastName = "student",
                    PasswordHash = hasher.HashPassword(null, "Student@123"),
                    EmailConfirmed = true
                }
        );
        }
    }
}