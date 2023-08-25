using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test1.Server.Models;

namespace Test1.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "Asd+23"),
                },
                new ApplicationUser
                {
                    Id = "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "User",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "Asd+23"),
                }
                );
        }
    }
}
