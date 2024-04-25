using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Mapping
{



    public class SimpleEventTypeMap : IEntityTypeConfiguration<SimpleEventType>
    {
        public void Configure(EntityTypeBuilder<SimpleEventType> builder)
        {
            builder.HasIndex(e => e.Name).IsUnique();
            builder.HasData(
                    new SimpleEventType { Id = 1, Name = "BookCar" },
                    new SimpleEventType { Id = 2, Name = "Comission" },
                    new SimpleEventType { Id = 3, Name = "Decomission" },
                    new SimpleEventType { Id = 4, Name = "ErrorIdentification" },
                    new SimpleEventType { Id = 5, Name = "TestDrive" },
                    new SimpleEventType { Id = 6, Name = "ShopConfiguration" },
                    new SimpleEventType { Id = 7, Name = "PreparedForDrive" },
                    new SimpleEventType { Id = 8, Name = "TagAssigned" },
                    new SimpleEventType { Id = 9, Name = "TagUnAssigned" },
                    new SimpleEventType { Id = 10, Name = "LoggerInstall" },
                    new SimpleEventType { Id = 11, Name = "LoggerUnInstall" },
                    new SimpleEventType { Id = 12, Name = "MainDriveEvent" },
                    new SimpleEventType { Id = 13, Name = "RoutineDrive" },
                    new SimpleEventType { Id = 14, Name = "TicketSubmission" }
                );
        }
    }
}

