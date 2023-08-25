using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test1.Shared.Domain;

namespace Test1.Server.Configurations.Entities
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    Name = "Black",
                    UpdatedBy = "System",
                    DateUpdated = DateTime.Now,
                },
                 new Color
                 {
                     Id = 2,
                     CreatedBy = "System",
                     DateCreated = DateTime.Now,
                     Name = "Blue",
                     UpdatedBy = "System",
                     DateUpdated = DateTime.Now,
                 }
                );

        }
    }
}
