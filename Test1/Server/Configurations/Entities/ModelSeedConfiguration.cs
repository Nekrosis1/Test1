using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test1.Shared.Domain;

namespace Test1.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
               new Model
               {
                   Id = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   Name = "Prius",
                   UpdatedBy = "System",
                   DateUpdated = DateTime.Now,
               },
               new Model
               {
                   Id = 2,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   Name = "Vitz",
                   UpdatedBy = "System",
                   DateUpdated = DateTime.Now,
               },
               new Model
               {
                   Id = 3,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   Name = "3 Series",
                   UpdatedBy = "System",
                   DateUpdated = DateTime.Now,
               },
               new Model
               {
                   Id = 4,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   Name = "X5",
                   UpdatedBy = "System",
                   DateUpdated = DateTime.Now,
               }
               );
        }
    }
}
