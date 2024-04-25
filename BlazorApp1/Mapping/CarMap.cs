using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Mapping
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //says: theres a car with a [cardetail that has  carId on it as a dependancy]
            builder.HasOne(c => c.CarDetail).WithOne(cd => cd.Car).HasForeignKey<CarDetail>(cd => cd.CarId);
            builder.HasMany(c => c.Loggers).WithOne(l => l.Car).HasForeignKey(l => l.CarId);
            builder.HasMany(e => e.Modules)
                    .WithMany(e => e.Cars)
                    .UsingEntity<CarModule>(
                        "CarModule",
                        l => l.HasOne<Module>().WithMany(e => e.CarModules).HasForeignKey(e => e.ModuleId).HasPrincipalKey(e => e.ModuleId),
                        r => r.HasOne<Car>().WithMany(e => e.CarModules).HasForeignKey(e => e.CarId).HasPrincipalKey(e => e.CarId),
                        j =>
                        {
                            j.HasKey(e => new { e.CarId, e.ModuleId });
                        });


            
            builder.HasData(
            new Car { HasLogger = false, HasHarness = false, HasTag = false, IsAdas = false, CarId = 1001, /*CarDetail = { CarId = 1001 },*/ Make = "Mercedes", Model = "EQE 400", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "California", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
            new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1002, Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG6", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {     LoggerId = 1 ,        HasLogger = true, HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1003, Make = "Mercedes", Model = "EQS 450+", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {     LoggerId = 3 ,        HasLogger = true, HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1004, Make = "Mercedes", Model = "GLS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7 * 2", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {     LoggerId = 5 ,        HasLogger = true, HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1005, Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {     LoggerId = 6 ,        HasLogger = true, HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1006, Make = "Mercedes", Model = "Maybach EQS 680", Year = 2023, TeleGeneration = "NTG7", Miles = 200, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {     LoggerId = 2 ,        HasLogger = true, HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1007, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car { LoggerId = 4 ,        HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1008, Make = "Mercedes", Model = "GLS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7 * 2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1009, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1010, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1011, Make = "Mercedes", Model = "EQS 450", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1012, Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1013, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1014, Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1015, Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1016, Make = "Mercedes", Model = "MAYBACH EQS 680", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1017, Make = "Mercedes", Model = "AMG GLE 63 S 4MAT", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1018, Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1019, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1020, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1021, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1022, Make = "Mercedes", Model = "C 300", Year = 2023, TeleGeneration = "GEN20", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1023, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1024, Make = "Mercedes", Model = "AMG CLA 45", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1025, Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1026, Make = "Mercedes", Model = "AMG S 63 e ", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1027, Make = "Mercedes", Model = "GLC 300", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1028, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1029, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1030, Make = "Mercedes", Model = "Maybach S 580", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1031, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1032, Make = "Mercedes", Model = "EQB 350 4MATIC", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1033, Make = "Mercedes", Model = "AMG S 63 e 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1034, Make = "Mercedes", Model = "EQS 550 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1035, Make = "Mercedes", Model = "AMG E 53 4MATIC", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,      CarId = 1036, Make = "Mercedes", Model = "E 350 4MATIC", Year = 2023, TeleGeneration = "GEN20", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1037, Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car {             HasLogger = false,HasHarness = false, HasTag = false, IsAdas = false,     CarId = 1038, Make = "Mercedes", Model = "EQS 450", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 },
                    new Car
                    {
                        HasLogger = false,
                        HasHarness = false,
                        HasTag = false,
                        IsAdas = false,
                        CarId = 1039, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "3de00zzz-2828-0000-0000-3de000000000", ParkingSpace = 1 }
                        );

        }
    }
}
