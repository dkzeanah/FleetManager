using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUser");

            // Key and properties configuration
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FriendlyName).HasMaxLength(50);
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).HasMaxLength(50);
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // Relationships configuration
            // Add any relationships if required
            // Seed a dummy user
            builder.HasData(new ApplicationUser
            {
                Id = "3de00zzz-2828-0000-0000-3de000000000",
                UserName = "DummyUser1",
                NormalizedUserName = "DUMMYUSER",
                Email = "dummyuser@example.com",
                NormalizedEmail = "DUMMYUSER@EXAMPLE.COM",
                FriendlyName = "Dummy User",
                // Other properties can be initialized here...
            });

            // Seed an admin user
            builder.HasData(new ApplicationUser
            {
                Id = "3de00zzz-2828-0000-0000-3de000000001",
                UserName = "Admin1",
                NormalizedUserName = "ADMIN",
                Email = "dkzeanah@gmail.com",
                NormalizedEmail = "DKZEANAH@GMAIL.COM",
                FriendlyName = "Admin User",
                // Other properties can be initialized here...
            });
        }
    }
}
