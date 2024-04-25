 
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class SourceMap : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Source");
            builder.Property(e => e.Id);
            builder.Property(e => e.Name);
            // Adding Unique Constraint
            builder.HasIndex(e => e.Name).IsUnique().HasDatabaseName("Source");
            builder.HasData(
                new Source { Id = 1, Name = "MarketBorrow" },
                new Source { Id = 2, Name = "Purchased" },
                new Source { Id = 3, Name = "Owned" }

            );
        }
    }
}
