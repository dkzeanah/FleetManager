using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    // Configure CarStaticDetail as an owned entity of Car
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(e => e.Id);
            builder.OwnsOne(e => e.CarStaticDetail, detail =>
            {
                detail.Property(e => e.Adas).HasDefaultValueSql("(1)");
                detail.ToTable("CarStaticDetail");
            });



            // Other configuration goes here...

            builder.HasData(
         // Seed the data

         new Car { Id = 1, Tagnumber = "180", Finas = "  X294-01019", Vin = "4JGGM2BB6PA000131", Adas = true, Make = "Mercedes", Model = "EQE 400", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "California", SourceId = 2, UserId = "d02a99db-8c5a-4e0f-9d01-1da28abf91a4" },
         new Car { Id = 2, Tagnumber = " 181", Finas = "X167-04607", Vin = "4JGFF8HB5NA357779", Adas = true , Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "d02a99db-8c5a-4e0f-9d01-1da28abf91a4" },
         new Car { Id = 3, Tagnumber = " 182", Finas = "X296-01198", Vin = "4JGDM2DB4RA003435", Adas = true , Make = "Mercedes", Model = "EQS 450+", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
         new Car { Id = 4, Tagnumber = " 183", Finas = "X167-06625", Vin = "4JGFF8FE9RA844776", Adas = true , Make = "Mercedes", Model = "GLS 580 4matic", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
         new Car { Id = 5, Tagnumber = " 184", Finas = "X294-01471", Vin = "4JGGM1CB8RA000790", Adas = true , Make = "Mercedes", Model = "EQE 350 4matic", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
         new Car { Id = 6, Tagnumber = " 185", Finas = "Z296-01209", Vin = "4JGDX5FB2RA003388", Adas = true , Make = "Mercedes", Model = "Maybach EQS 680", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
         new Car { Id = 7, Tagnumber = " 186", Finas = "X296-01210", Vin = "4JGDM4EB5RA003437", Adas = true , Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
         new Car { Id = 8, Tagnumber = " 187", Finas = "X167-06656", Vin = "4JGFF5KE1RA844775", Adas = true , Make = "Mercedes", Model = "GLS 450 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
         new Car { Id = 9, Tagnumber = " 188", Finas = "X294-01457", Vin = "4JGGM5DB8RA001590", Adas = true , Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 10, Tagnumber = " 189", Finas = "X296-00421", Vin = "4JGDM4EB6PA000351", Adas = true , Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 11, Tagnumber = " 190", Finas = "X296-00395", Vin = "4JGDM2DB9PA000205", Adas = true , Make = "Mercedes", Model = "EQS 450", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 12, Tagnumber = " 191", Finas = "X167-06686", Vin = "4JGFF8HB1RA844774", Adas = true , Make = "Mercedes", Model = "Maybach GLS 600", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 13, Tagnumber = " 192", Finas = "X294-01532", Vin = "4JGGM2BB2RA000792", Adas = true , Make = "Mercedes", Model = "EQE 350+", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 14, Tagnumber = " 193", Finas = "X296-00702", Vin = "4JGDM2EB1PU000194", Adas = true , Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 15, Tagnumber = " 195", Finas = "V167-06463", Vin = "4JGFB4GB3RA809370", Adas = true , Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 16, Tagnumber = " 196", Finas = "Z296-01192", Vin = "4JGDX5FB9RA003386", Adas = true , Make = "Mercedes", Model = "MAYBACH EQS 680", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 17, Tagnumber = " 197", Finas = "C167-06461", Vin = "4JGFD8KB4RA809371", Adas = true , Make = "Mercedes", Model = "AMG GLE 63 S 4MAT", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 18, Tagnumber = " 198", Finas = "V167-06567", Vin = "4JGFB4GB1PA883660", Adas = true , Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 19, Tagnumber = " 199", Finas = "X294-01456", Vin = "4JGGM5DBXRA001588", Adas = true , Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 20, Tagnumber = " 288", Finas = "X296-00848", Vin = "4JGDM4EB7PA000701", Adas = true , Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 21, Tagnumber = " 638", Finas = "V297-02377", Vin = "W1KCG4EB4PA019834", Adas = true , Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 22, Tagnumber = " 651", Finas = "W206-01531", Vin = "W1KAF4GB9NR000041", Adas = true , Make = "Mercedes", Model = "C 300", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 23, Tagnumber = " 652", Finas = "V297-01008", Vin = "W1KCG4EB7NA000823", Adas = true , Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 24, Tagnumber = " 653", Finas = "A118-01377", Vin = "W1K5J5EB8RN368913", Adas = true , Make = "Mercedes", Model = "AMG CLA 45 ", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 25, Tagnumber = " 654", Finas = "V297-01062", Vin = "W1KCG2EB8NA003265", Adas = true , Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 26, Tagnumber = " 655", Finas = "V223-05154", Vin = "W1K6G8CB9RA200096", Adas = true , Make = "Mercedes", Model = "AMG S 63 e ", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 27, Tagnumber = " 657", Finas = "X254-02459", Vin = "W1NKM4GB3PF001221", Adas = true , Make = "Mercedes", Model = "GLC 300", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 28, Tagnumber = " 658", Finas = "V295-01073", Vin = "W1KEG2BB5NF000498", Adas = true , Make = "Mercedes", Model = "EQE 350+", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 29, Tagnumber = " 659", Finas = "V295-01074", Vin = "W1KEG2BB7NF000499", Adas = true , Make = "Mercedes", Model = "EQE 350+", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 30, Tagnumber = " 660", Finas = "Z223-05153", Vin = "W1K6X7GB9RA203259", Adas = true , Make = "Mercedes", Model = "Maybach S 580", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 31, Tagnumber = " 661", Finas = "N295-01333", Vin = "W1KEG5DB3PF005779", Adas = true , Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 32, Tagnumber = " 662", Finas = "X243-01749", Vin = "W1N9M1DB3RN027408", Adas = true , Make = "Mercedes", Model = "EQB 350 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 33, Tagnumber = " 663", Finas = "V223-04879", Vin = "W1K6G8CB5PA159432", Adas = true , Make = "Mercedes", Model = "AMG S 63 e 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 34, Tagnumber = " 664", Finas = "V297-01298", Vin = "W1KCG4EB6NA000411", Adas = true , Make = "Mercedes", Model = "EQS 550 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 35, Tagnumber = " 665", Finas = "A238-02435", Vin = "W1K1K6BB7PF185712", Adas = true , Make = "Mercedes", Model = "AMG E 53 4MATIC+", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 36, Tagnumber = " 666", Finas = "W214-01098", Vin = "W1KLF4HB7RA000650", Adas = true , Make = "Mercedes", Model = "E 350 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 37, Tagnumber = " 668", Finas = "X294-00461", Vin = "4JGGM1CB5PA000386", Adas = true , Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 38, Tagnumber = " 669", Finas = "X296-00322", Vin = "4JGDM2DB2PA000031", Adas = true , Make = "Mercedes", Model = "EQS 450", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" },
        new Car { Id = 39, Tagnumber = "670", Finas = "V295-00503", Vin = "W1KEG2BB5PF000620" ,Adas = true,  Make = "Mercedes", Model = "EQE 350+", Year = 2025, TeleGeneration = "", Miles = 0, Location = "Tuscaloosa", SourceId = 2, UserId = "00000000-8c5a-4e0f-9d01-000000000000" }



                    // ... rest of the data ...

                    );
            // Configure Logger as an owned entity of Car
            builder.OwnsMany(e => e.Loggers, logger =>
            {
                logger.Property(e => e.LoggerId).HasColumnName("LoggerId");
                logger.Property(e => e.CarId).HasColumnName("CardId");
                logger.Property(e => e.TypeLogger).HasMaxLength(50);
            });

            // Configure CarStatus as an owned entity of Car
            builder.OwnsMany(e => e.CarStatus, status =>
            {
                status.Property(e => e.CarId).HasColumnName("CarId");
                status.Property(e => e.StatusId).HasColumnName("StatusId");
                status.Property(e => e.StatusTime).HasColumnType("datetime");
                //status.HasOne(d => d.Status).WithMany()
            });

        }


    }
}
