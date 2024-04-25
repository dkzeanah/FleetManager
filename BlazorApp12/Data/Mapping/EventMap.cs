
 
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class EventMap : IEntityTypeConfiguration<Event>
        {
            public void Configure(EntityTypeBuilder<Event> builder)
            {
                builder.HasKey(e => e.Id);
                builder.ToTable("Events");
                builder.Property(e => e.Id)
                    .HasColumnName("Id");
           
            }
        }



    }


