using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Test1.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "9e24a193-1061-45cd-be67-16cd9f4acedb",
                    UserId = "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "9e24a193-1061-45cd-be67-46cd9f4aceda",
                    UserId = "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                }
                );
        }
    }
}
