using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Test1.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "9e24a193-1061-45cd-be67-46cd9f4aceda",
                    Name = "User",
                    NormalizedName = "USER",
                },
                new IdentityRole
                {
                    Id = "9e24a193-1061-45cd-be67-16cd9f4acedb",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                }
            );
        }
    }
}
