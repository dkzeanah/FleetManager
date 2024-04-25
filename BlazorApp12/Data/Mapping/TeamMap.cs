 
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
            builder.HasMany(t => t.TeamMembers).WithOne(u => u.Team).HasForeignKey(u => u.TeamId);
            builder.HasOne(t => t.TeamTimeline).WithOne(tt => tt.Team).HasForeignKey<TeamTimeline>(tt => tt.TeamId);
            
            
            builder.HasData(
                new Team { Id = 1, Name = "Unassigned" },
                new Team { Id = 2, Name = "Adas" },
                new Team { Id = 3, Name = "Telematics" }
            );
        }
    }
}
