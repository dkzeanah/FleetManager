using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class TicketCategoryMap : IEntityTypeConfiguration<TicketCategory>
    {
        public void Configure(EntityTypeBuilder<TicketCategory> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasData(
                new TicketCategory { Id = 1, Name = "Voca1", DefaultPriority = 1 },
                new TicketCategory { Id = 2, Name = "Voca2", DefaultPriority = 2 },
                new TicketCategory { Id = 3, Name = "Voca3", DefaultPriority = 3 }
            );
        }
    }
}
