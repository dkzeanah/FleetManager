using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{
    public class DetailTypeMap : IEntityTypeConfiguration<DetailType>
    {

        public void Configure(EntityTypeBuilder<DetailType> builder)
        {

            builder.HasData(
                new DetailType { Id = 1, Name = "Ticket" },
                new DetailType { Id = 2, Name = "Car" },
                new DetailType { Id = 3, Name = "Event" },
                new DetailType { Id = 4, Name = "Ticket" },
                new DetailType { Id = 5, Name = "Shop" },
                new DetailType { Id = 6, Name = "Highlight" },
                new DetailType { Id = 7, Name = "Improvement" },
                new DetailType { Id = 8, Name = "Critique" }
            );
        }
    }
}

