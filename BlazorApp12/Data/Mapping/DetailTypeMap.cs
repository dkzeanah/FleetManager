using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{
    public class DetailTypeMap : IEntityTypeConfiguration<DetailType>
    {

        public void Configure(EntityTypeBuilder<DetailType> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd(); // Makes Id auto increment
            builder.HasIndex(e => e.Name).IsUnique(); // Makes Name unique
            builder.HasData(
                new DetailType { Id = 1, Name = "Ticket" },
                new DetailType { Id = 2, Name = "Car" },
                new DetailType { Id = 3, Name = "UserCarEvent" },
                new DetailType { Id = 4, Name = "Critique" },
                new DetailType { Id = 5, Name = "Shop" },
                new DetailType { Id = 6, Name = "Highlight" },
                new DetailType { Id = 7, Name = "Improvement" }
            );
        }
    }
}

