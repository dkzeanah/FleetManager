using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Mapping
{
    public class BlankMap : IEntityTypeConfiguration<Blank>
    {
        public void Configure(EntityTypeBuilder<Blank> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasData(
                new Blank { Id = 1, Name = "Item 1", String = "This is item 1 data" }
            );
        }
    }
}
