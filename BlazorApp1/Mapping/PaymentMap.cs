using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Mapping
{
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.PaymentId);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
            builder.Property(p => p.DueDate).IsRequired();
            builder.Property(p => p.Amount).IsRequired();
            // Additional configurations can be added here
        }
    }
}
