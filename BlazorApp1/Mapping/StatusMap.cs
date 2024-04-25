using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Mapping
{
    public class StatusMap : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Status");
            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("Id");
            builder.Property(e => e.Name).HasMaxLength(50);
            // Adding Unique Constraint
            builder.HasIndex(e => e.Name).IsUnique().HasName("UX_Status_Name");
            builder.HasData(
                new Status { Id = 1, Name = "Available" },
                new Status { Id = 2, Name = "NotAvailable" },
                new Status { Id = 3, Name = "AwaitingAction" }

            );
        }
    }



}
