 
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class RoleEventMappingMap : IEntityTypeConfiguration<RoleEventMapping>
    {
        public void Configure(EntityTypeBuilder<RoleEventMapping> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasIndex(r => r.RoleId).IsUnique();
            builder.HasData(
                new RoleEventMapping { Id = 1, RoleId = "1", DefaultEventTypeId = 1 }
            );
        }
    }
}
