
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BlazorApp1.CarModels;

    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            // Set table name
            builder.ToTable("Events");

            // Configure primary key
            builder.HasKey(e => e.Id);

            // Configure columns
            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd(); // Auto increment

            builder.Property(e => e.CarId)
                .HasColumnName("CarId");

            builder.Property(e => e.UserId)
                .HasColumnName("UserId");

            //... Similarly for other properties

            // Configure relationships
            builder.HasOne(e => e.User)
                .WithMany(u => u.Events) // Assuming ApplicationUser has no navigation property back to Event
                .HasForeignKey(e => e.UserId);

            builder.HasOne(e => e.SimpleEventType)
                .WithMany() // Assuming SimpleEventType has no navigation property back to Event
                .HasForeignKey(e => e.SimpleEventTypeId);

           /* builder.HasMany(e => e.EventDetails)
                .WithOne() // Assuming EventDetail has no navigation property back to Event
                .HasForeignKey(e => e.EventDetailId);

            builder.HasMany(e => e.UserEvents)
                .WithOne() // Assuming UserEvent has no navigation property back to Event
                .HasForeignKey(e => e.UserEventId);*/
        }
    }




}


