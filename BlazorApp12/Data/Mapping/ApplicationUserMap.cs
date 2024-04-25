using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{


    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // Table Configuration
            builder.ToTable("ApplicationUser");

            // Primary Key Configuration
            builder.HasKey(e => e.Id);

            // Property Configurations
            builder.Property(e => e.FriendlyName); //.HasDefaultValueSql("(N'')");

            // Index Configuration
            //builder.HasIndex(e => e.SomeStringProperty).IsUnique();

            // Owned Entity Configuration
            builder.OwnsOne(e => e.ApplicationUserStaticDetail, detail =>
            {
                detail.ToTable("ApplicationUserStaticDetail");
                //detail.HasKey(e => e.Id);

                // Property Configurations for the owned entity
               // detail.Property(e => e.SomeDetailStringProperty).HasMaxLength(50);
               // detail.Property(e => e.SomeDetailIntProperty).HasDefaultValue(1);

                // Index Configuration for the owned entity
               // detail.HasIndex(e => e.SomeDetailStringProperty);

                // Other configurations for the owned entity if needed
            });

            // Relationships
            //builder.HasMany(e => e.Orders).WithOne(o => o.ApplicationUser).HasForeignKey(o => o.UserId);

            // Other Configurations
            // Examples include setting concurrency tokens, shadow properties, query filters, etc.
        }
    }
}

 
 