using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{
    public class TeamTimelineMap : IEntityTypeConfiguration<TeamTimeline>
    {
        public void Configure(EntityTypeBuilder<TeamTimeline> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(t => t.Team).WithOne(t => t.TeamTimeline).HasForeignKey<TeamTimeline>(t => t.TeamId);
        }
    }

   

   
    

   
    
}
