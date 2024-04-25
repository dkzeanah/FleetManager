using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasData(
                new Team { Id = 1, Name = "Unassigned" },
                new Team { Id = 2, Name = "Adas" },
                new Team { Id = 3, Name = "Telematics" }
            );
        }
    }
}
