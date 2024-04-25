using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Mapping
{
    public class SourceMap : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Sources");
            builder.Property(e => e.Id);
            builder.Property(e => e.Name);
            // Adding Unique Constraint
            builder.HasIndex(e => e.Name).IsUnique().HasName("UX_Source_Name");
            builder.HasData(
                new Source { Id = 1, Name = "Unknown" },
                new Source { Id = 2, Name = "Purchased" },
                new Source { Id = 3, Name = "Owned" },
                new Source
                {
                    Id = 4,
                    Name = "MarketBorrow"
                }

            );
        }
    }
}
