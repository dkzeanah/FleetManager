using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{
    public class UserCarEventMap : IEntityTypeConfiguration<UserCarEvent>
    {
        public void Configure(EntityTypeBuilder<UserCarEvent> builder)
        {
            // Key and table definition
            builder.HasKey(e => e.Id);
            builder.ToTable("UserCarEvent");

            // Properties
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.CarId).HasColumnName("CarId");
            builder.Property(e => e.EndTime).HasColumnType("datetime");
            builder.Property(e => e.EventTypeId).HasColumnName("EventTypeId");
            builder.Property(e => e.StartTime).HasColumnType("datetime");
            builder.Property(e => e.UserId).HasMaxLength(450).HasColumnName("UserId");

            // Relationships
            builder.HasOne(d => d.EventType);

            builder.HasOne(d => d.User).WithMany(p => p.UserCarEvents)
                .HasForeignKey(d => d.UserId);

            // Collection of UserEventDetails
           // builder.HasOne(e => e.UserCarEventDetails).WithMany()
                //.HasForeignKey(d => d.UserEventDetailId)
                //.OnDelete(DeleteBehavior.ClientSetNull);

          


        }
    }

}
