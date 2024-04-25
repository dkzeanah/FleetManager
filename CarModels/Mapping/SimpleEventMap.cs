
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class SimpleEventMap : IEntityTypeConfiguration<SimpleEvent>
        {
            public void Configure(EntityTypeBuilder<SimpleEvent> builder)
            {
                builder.HasKey(e => e.Id);
                builder.ToTable("SimpleEvent");
                builder.Property(e => e.Id)
                    .HasColumnName("Id");
               // builder.Property(e => e.Name).HasMaxLength(50);
                // Adding Unique Constraint
               // builder.HasIndex(e => e.Name).IsUnique().HasName("UX_Event_Name");
            }
        }



    }


