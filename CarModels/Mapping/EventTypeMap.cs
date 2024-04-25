using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{



        public class EventTypeMap : IEntityTypeConfiguration<EventType>
        {
            public void Configure(EntityTypeBuilder<EventType> builder)
            {
            builder.HasIndex(e => e.Name).IsUnique();
            builder.HasData(
                    new EventType { Id = 1, Name = "BookCar" },
                    new EventType { Id = 2, Name = "Comission" },
                    new EventType { Id = 3, Name = "Decomission" },
                    new EventType { Id = 4, Name = "ErrorIdentification" },
                    new EventType { Id = 5, Name = "TestDrive" },
                    new EventType { Id = 6, Name = "ShopConfiguration" },
                    new EventType { Id = 7, Name = "PreparedForDrive" },
                    new EventType { Id = 8, Name = "TagAssigned" },
                    new EventType { Id = 9, Name = "TagUnAssigned" },
                    new EventType { Id = 10, Name = "LoggerInstall" },
                    new EventType { Id = 11, Name = "LoggerUnInstall" },
                    new EventType { Id = 12, Name = "MainDriveEvent" },
                    new EventType { Id = 13, Name = "RoutineDrive" },
                    new EventType {  Id = 14, Name = "TicketSubmission" }
                );
        }
        }
    }

