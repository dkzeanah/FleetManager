 
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class UserEventMap : IEntityTypeConfiguration<UserEvent>
    {
        public void Configure(EntityTypeBuilder<UserEvent> builder)
        {
            builder.HasOne(ue => ue.UserCarEvent)
        .WithOne(uce => uce.UserEvents)
        .HasForeignKey<UserCarEvent>(uce => uce.Id); // Configuring the dependent side
            
             builder.HasOne(ue => ue.ApplicationUser)
                         .WithMany(u => u.UserEvents)
                //.HasForeignKey(ue => ue.UserId)
                 .OnDelete(DeleteBehavior.NoAction); // or .OnDelete(DeleteBehavior.SetNull);


            // builder.HasData( new UserEvent {  });
        }
    }
}
