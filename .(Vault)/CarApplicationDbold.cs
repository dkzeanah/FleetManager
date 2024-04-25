using BlazorApp1.CarModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Car2> Car2s { get; set; }

        public virtual DbSet<CarStaticDetail> CarStaticDetails { get; set; }
        public virtual DbSet<CarStatus> CarStatuses { get; set; }
        public virtual DbSet<CarStatusNew> CarStatusNews { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        //drivers superceed other user types (own objects) on
        //account of complexity increase in stat tracking
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<NoteEventDetail> NoteEventDetails { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<UserEventDetail> UserEventDetails { get; set; }
        public virtual DbSet<UserEvent> UserEvents { get; set; }
        public virtual DbSet<RoleEventMapping> RoleEventMappings { get; set; }
        public virtual DbSet<BlankModel> BlankModels { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Both methods serve the same purpose of seeding initial data into the Car table.
             
            The inline data in entity.HasData() is convenient when you have a single object
            to insert.
            The separate HasData() calls are useful when you have multiple objects to 
            insert, as you can chain multiple HasData() calls to provide separate sets 
            of data.
            It's important to note that when using separate HasData() calls, the order 
            of the calls matters. EF Core will generate SQL statements to insert the data
            in the order the HasData() calls are made.
            The primary difference is in the coding style and organization of the data 
            insertion. You can choose the method that aligns better with your coding style
            and requirements.*/

            /* modelBuilder.Entity<ApplicationUser>()
         .HasOne(a => a.ApplicationUserDetail)
         .WithOne(b => b.ApplicationUser)
         .HasForeignKey<ApplicationUserDetail>(b => b.ApplicationUser.Id);*/

            modelBuilder.Entity<Car2>(entity =>
            {
                entity.ToTable("Car2s");
                entity.HasKey("Id");
                /*entity.HasData(
                    new Car
                    {
                        CarId = 2,
                        Make = "Mercedes",
                        Model = "Maybach GLS 600",
                        Year = 2023,
                        TeleGeneration = "NTG6",
                        Miles = 0,
                        Location = "Tuscaloosa",
                        SourceId = 2,
                        UserId = "d02a99db-8c5a-4e0f-9d01-1da28abf91a4"
                    }
                    );*/
            });

            modelBuilder.Entity<Car2>().HasData(
        new Car2 { Id = 1001, Make = "Mercedes", Model = "EQE 400", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "California", SourceId = 2, UserId = "default" },
        new Car2 { Id = 1002, Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG6", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1003, Make = "Mercedes", Model = "EQS 450+", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1004, Make = "Mercedes", Model = "GLS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7 * 2", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1005, Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1006, Make = "Mercedes", Model = "Maybach EQS 680", Year = 2023, TeleGeneration = "NTG7", Miles = 200, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1007, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1008, Make = "Mercedes", Model = "GLS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7 * 2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1009, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1010, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1011, Make = "Mercedes", Model = "EQS 450", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1012, Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1013, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1014, Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1015, Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1016, Make = "Mercedes", Model = "MAYBACH EQS 680", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1017, Make = "Mercedes", Model = "AMG GLE 63 S 4MAT", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1018, Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1019, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1020, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1021, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1022, Make = "Mercedes", Model = "C 300", Year = 2023, TeleGeneration = "GEN20", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1023, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1024, Make = "Mercedes", Model = "AMG CLA 45", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1025, Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1026, Make = "Mercedes", Model = "AMG S 63 e ", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1027, Make = "Mercedes", Model = "GLC 300", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1028, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1029, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1030, Make = "Mercedes", Model = "Maybach S 580", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1031, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1032, Make = "Mercedes", Model = "EQB 350 4MATIC", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1033, Make = "Mercedes", Model = "AMG S 63 e 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1034, Make = "Mercedes", Model = "EQS 550 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1035, Make = "Mercedes", Model = "AMG E 53 4MATIC", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1036, Make = "Mercedes", Model = "E 350 4MATIC", Year = 2023, TeleGeneration = "GEN20", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1037, Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1038, Make = "Mercedes", Model = "EQS 450", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car2 { Id = 1039, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" }
            );


            modelBuilder.Entity<CarStaticDetail2>()
           .HasOne(cd => cd.Car)
           .WithOne(); 
           

            modelBuilder.Entity<CarStaticDetail2>().HasData(
   new CarStaticDetail2 {Id = 1001, CarId = 1001, Tag = "180", Finas = "X294-01019", Vin = "4JGGM2BB6PA000131" , Adas = "0"  },
        new CarStaticDetail2 {Id = 1002, CarId = 1002, Tag = "181", Finas = "X167-04607", Vin = "4JGFF8HB5NA357779" , Adas = "0" },
        new CarStaticDetail2 {Id = 1003, CarId = 1003, Tag = "182", Finas = "X296-01198", Vin = "4JGDM2DB4RA003435" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1004, CarId = 1004, Tag = "183", Finas = "X167-06625", Vin = "4JGFF8FE9RA844776" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1005, CarId = 1005, Tag = "184", Finas = "X294-01471", Vin = "4JGGM1CB8RA000790" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1006, CarId = 1006, Tag = "185", Finas = "Z296-01209", Vin = "4JGDX5FB2RA003388" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1007, CarId = 1007, Tag = "186", Finas = "X296-01210", Vin = "4JGDM4EB5RA003437" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1008, CarId = 1008, Tag = "187", Finas = "X167-06656", Vin = "4JGFF5KE1RA844775" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1009, CarId = 1009, Tag = "188", Finas = "X294-01457", Vin = "4JGGM5DB8RA001590" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1010, CarId = 1010, Tag = "189", Finas = "X296-00421", Vin = "4JGDM4EB6PA000351" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1011, CarId = 1011, Tag = "190", Finas = "X296-00395", Vin = "4JGDM2DB9PA000205" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1012, CarId = 1012, Tag = "191", Finas = "X167-06686", Vin = "4JGFF8HB1RA844774" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1013, CarId = 1013, Tag = "192", Finas = "X294-01532", Vin = "4JGGM2BB2RA000792" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1014, CarId = 1014, Tag = "193", Finas = "X296-00702", Vin = "4JGDM2EB1PU000194" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1015, CarId = 1015, Tag = "195", Finas = "V167-06463", Vin = "4JGFB4GB3RA809370" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1016, CarId = 1016, Tag = "196", Finas = "Z296-01192", Vin = "4JGDX5FB9RA003386" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1017, CarId = 1017, Tag = "197", Finas = "C167-06461", Vin = "4JGFD8KB4RA809371" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1018, CarId = 1018, Tag = "198", Finas = "V167-06567", Vin = "4JGFB4GB1PA883660" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1019, CarId = 1019, Tag = "199", Finas = "X294-01456", Vin = "4JGGM5DBXRA001588" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1020, CarId = 1020, Tag = "288", Finas = "X296-00848", Vin = "4JGDM4EB7PA000701" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1021, CarId = 1021, Tag = "638", Finas = "V297-02377", Vin = "W1KCG4EB4PA019834" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1022, CarId = 1022, Tag = "651", Finas = "W206-01531", Vin = "W1KAF4GB9NR000041" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1023, CarId = 1023, Tag = "652", Finas = "V297-01008", Vin = "W1KCG4EB7NA000823" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1024, CarId = 1024, Tag = "653", Finas = "A118-01377", Vin = "W1K5J5EB8RN368913" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1025, CarId = 1025, Tag = "654", Finas = "V297-01062", Vin = "W1KCG2EB8NA003265" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1026, CarId = 1026, Tag = "655", Finas = "V223-05154", Vin = "W1K6G8CB9RA200096" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1027, CarId = 1027, Tag = "657", Finas = "X254-02459", Vin = "W1NKM4GB3PF001221" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1028, CarId = 1028, Tag = "658", Finas = "V295-01073", Vin = "W1KEG2BB5NF000498" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1029, CarId = 1029, Tag = "659", Finas = "V295-01074", Vin = "W1KEG2BB7NF000499" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1030, CarId = 1030, Tag = "660", Finas = "Z223-05153", Vin = "W1K6X7GB9RA203259" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1031, CarId = 1031, Tag = "661", Finas = "N295-01333", Vin = "W1KEG5DB3PF005779" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1032, CarId = 1032, Tag = "662", Finas = "X243-01749", Vin = "W1N9M1DB3RN027408" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1033, CarId = 1033, Tag = "663", Finas = "V223-04879", Vin = "W1K6G8CB5PA159432" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1034, CarId = 1034, Tag = "664", Finas = "V297-01298", Vin = "W1KCG4EB6NA000411" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1035, CarId = 1035, Tag = "665", Finas = "A238-02435", Vin = "W1K1K6BB7PF185712" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1036, CarId = 1036, Tag = "666", Finas = "W214-01098", Vin = "W1KLF4HB7RA000650" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1037, CarId = 1037, Tag = "668", Finas = "X294-00461", Vin = "4JGGM1CB5PA000386" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1038, CarId = 1038, Tag = "669", Finas = "X296-00322", Vin = "4JGDM2DB2PA000031" , Adas = "0"   },
        new CarStaticDetail2 {Id = 1039, CarId = 1039, Tag = "670", Finas = "V295-00503", Vin = "W1KEG2BB5PF000620" , Adas = "0"   }

                );


            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");
                entity.HasKey("CarId");
                /*entity.HasData(
                    new Car
                    {
                        CarId = 2,
                        Make = "Mercedes",
                        Model = "Maybach GLS 600",
                        Year = 2023,
                        TeleGeneration = "NTG6",
                        Miles = 0,
                        Location = "Tuscaloosa",
                        SourceId = 2,
                        UserId = "d02a99db-8c5a-4e0f-9d01-1da28abf91a4"
                    }
                    );*/
            });

            modelBuilder.Entity<Car>().HasData(
        new Car { CarId = 1001, Make = "Mercedes", Model = "EQE 400", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "California", SourceId = 2, UserId = "default" },
        new Car { CarId = 1002, Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG6", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1003, Make = "Mercedes", Model = "EQS 450+", Year = 2023, TeleGeneration = "NTG7", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1004, Make = "Mercedes", Model = "GLS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7 * 2", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1005, Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1006, Make = "Mercedes", Model = "Maybach EQS 680", Year = 2023, TeleGeneration = "NTG7", Miles = 200, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1007, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1008, Make = "Mercedes", Model = "GLS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7 * 2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1009, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1010, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1011, Make = "Mercedes", Model = "EQS 450", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1012, Make = "Mercedes", Model = "Maybach GLS 600", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1013, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1014, Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1015, Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1016, Make = "Mercedes", Model = "MAYBACH EQS 680", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1017, Make = "Mercedes", Model = "AMG GLE 63 S 4MAT", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1018, Make = "Mercedes", Model = "GLE 400 e 4MATIC", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1019, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1020, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1021, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1022, Make = "Mercedes", Model = "C 300", Year = 2023, TeleGeneration = "GEN20", Miles = 5000, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1023, Make = "Mercedes", Model = "EQS 580 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1024, Make = "Mercedes", Model = "AMG CLA 45", Year = 2023, TeleGeneration = "NTG7*2", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1025, Make = "Mercedes", Model = "EQS 450 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1026, Make = "Mercedes", Model = "AMG S 63 e ", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1027, Make = "Mercedes", Model = "GLC 300", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1028, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1029, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1030, Make = "Mercedes", Model = "Maybach S 580", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1031, Make = "Mercedes", Model = "AMG EQE 53 4MAT", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1032, Make = "Mercedes", Model = "EQB 350 4MATIC", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1033, Make = "Mercedes", Model = "AMG S 63 e 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1034, Make = "Mercedes", Model = "EQS 550 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1035, Make = "Mercedes", Model = "AMG E 53 4MATIC", Year = 2023, TeleGeneration = "NTG6", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1036, Make = "Mercedes", Model = "E 350 4MATIC", Year = 2023, TeleGeneration = "GEN20", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1037, Make = "Mercedes", Model = "EQE 350 4MATIC", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1038, Make = "Mercedes", Model = "EQS 450", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" },
        new Car { CarId = 1039, Make = "Mercedes", Model = "EQE 350", Year = 2023, TeleGeneration = "NTG7", Miles = 0, Location = "Tuscaloosa", SourceId = 1, UserId = "default" }
            );

            modelBuilder.Entity<CarStaticDetail>()
           .HasOne(cd => cd.Car)
           .WithOne();


            modelBuilder.Entity<CarStaticDetail>().HasData(
   new CarStaticDetail { Id = 1001, CarId = 1001, Tag = "180", Finas = "X294-01019", Vin = "4JGGM2BB6PA000131", Adas = "0" },
        new CarStaticDetail { Id = 1002, CarId = 1002, Tag = "181", Finas = "X167-04607", Vin = "4JGFF8HB5NA357779", Adas = "0" },
        new CarStaticDetail { Id = 1003, CarId = 1003, Tag = "182", Finas = "X296-01198", Vin = "4JGDM2DB4RA003435", Adas = "0" },
        new CarStaticDetail { Id = 1004, CarId = 1004, Tag = "183", Finas = "X167-06625", Vin = "4JGFF8FE9RA844776", Adas = "0" },
        new CarStaticDetail { Id = 1005, CarId = 1005, Tag = "184", Finas = "X294-01471", Vin = "4JGGM1CB8RA000790", Adas = "0" },
        new CarStaticDetail { Id = 1006, CarId = 1006, Tag = "185", Finas = "Z296-01209", Vin = "4JGDX5FB2RA003388", Adas = "0" },
        new CarStaticDetail { Id = 1007, CarId = 1007, Tag = "186", Finas = "X296-01210", Vin = "4JGDM4EB5RA003437", Adas = "0" },
        new CarStaticDetail { Id = 1008, CarId = 1008, Tag = "187", Finas = "X167-06656", Vin = "4JGFF5KE1RA844775", Adas = "0" },
        new CarStaticDetail { Id = 1009, CarId = 1009, Tag = "188", Finas = "X294-01457", Vin = "4JGGM5DB8RA001590", Adas = "0" },
        new CarStaticDetail { Id = 1010, CarId = 1010, Tag = "189", Finas = "X296-00421", Vin = "4JGDM4EB6PA000351", Adas = "0" },
        new CarStaticDetail { Id = 1011, CarId = 1011, Tag = "190", Finas = "X296-00395", Vin = "4JGDM2DB9PA000205", Adas = "0" },
        new CarStaticDetail { Id = 1012, CarId = 1012, Tag = "191", Finas = "X167-06686", Vin = "4JGFF8HB1RA844774", Adas = "0" },
        new CarStaticDetail { Id = 1013, CarId = 1013, Tag = "192", Finas = "X294-01532", Vin = "4JGGM2BB2RA000792", Adas = "0" },
        new CarStaticDetail { Id = 1014, CarId = 1014, Tag = "193", Finas = "X296-00702", Vin = "4JGDM2EB1PU000194", Adas = "0" },
        new CarStaticDetail { Id = 1015, CarId = 1015, Tag = "195", Finas = "V167-06463", Vin = "4JGFB4GB3RA809370", Adas = "0" },
        new CarStaticDetail { Id = 1016, CarId = 1016, Tag = "196", Finas = "Z296-01192", Vin = "4JGDX5FB9RA003386", Adas = "0" },
        new CarStaticDetail { Id = 1017, CarId = 1017, Tag = "197", Finas = "C167-06461", Vin = "4JGFD8KB4RA809371", Adas = "0" },
        new CarStaticDetail { Id = 1018, CarId = 1018, Tag = "198", Finas = "V167-06567", Vin = "4JGFB4GB1PA883660", Adas = "0" },
        new CarStaticDetail { Id = 1019, CarId = 1019, Tag = "199", Finas = "X294-01456", Vin = "4JGGM5DBXRA001588", Adas = "0" },
        new CarStaticDetail { Id = 1020, CarId = 1020, Tag = "288", Finas = "X296-00848", Vin = "4JGDM4EB7PA000701", Adas = "0" },
        new CarStaticDetail { Id = 1021, CarId = 1021, Tag = "638", Finas = "V297-02377", Vin = "W1KCG4EB4PA019834", Adas = "0" },
        new CarStaticDetail { Id = 1022, CarId = 1022, Tag = "651", Finas = "W206-01531", Vin = "W1KAF4GB9NR000041", Adas = "0" },
        new CarStaticDetail { Id = 1023, CarId = 1023, Tag = "652", Finas = "V297-01008", Vin = "W1KCG4EB7NA000823", Adas = "0" },
        new CarStaticDetail { Id = 1024, CarId = 1024, Tag = "653", Finas = "A118-01377", Vin = "W1K5J5EB8RN368913", Adas = "0" },
        new CarStaticDetail { Id = 1025, CarId = 1025, Tag = "654", Finas = "V297-01062", Vin = "W1KCG2EB8NA003265", Adas = "0" },
        new CarStaticDetail { Id = 1026, CarId = 1026, Tag = "655", Finas = "V223-05154", Vin = "W1K6G8CB9RA200096", Adas = "0" },
        new CarStaticDetail { Id = 1027, CarId = 1027, Tag = "657", Finas = "X254-02459", Vin = "W1NKM4GB3PF001221", Adas = "0" },
        new CarStaticDetail { Id = 1028, CarId = 1028, Tag = "658", Finas = "V295-01073", Vin = "W1KEG2BB5NF000498", Adas = "0" },
        new CarStaticDetail { Id = 1029, CarId = 1029, Tag = "659", Finas = "V295-01074", Vin = "W1KEG2BB7NF000499", Adas = "0" },
        new CarStaticDetail { Id = 1030, CarId = 1030, Tag = "660", Finas = "Z223-05153", Vin = "W1K6X7GB9RA203259", Adas = "0" },
        new CarStaticDetail { Id = 1031, CarId = 1031, Tag = "661", Finas = "N295-01333", Vin = "W1KEG5DB3PF005779", Adas = "0" },
        new CarStaticDetail { Id = 1032, CarId = 1032, Tag = "662", Finas = "X243-01749", Vin = "W1N9M1DB3RN027408", Adas = "0" },
        new CarStaticDetail { Id = 1033, CarId = 1033, Tag = "663", Finas = "V223-04879", Vin = "W1K6G8CB5PA159432", Adas = "0" },
        new CarStaticDetail { Id = 1034, CarId = 1034, Tag = "664", Finas = "V297-01298", Vin = "W1KCG4EB6NA000411", Adas = "0" },
        new CarStaticDetail { Id = 1035, CarId = 1035, Tag = "665", Finas = "A238-02435", Vin = "W1K1K6BB7PF185712", Adas = "0" },
        new CarStaticDetail { Id = 1036, CarId = 1036, Tag = "666", Finas = "W214-01098", Vin = "W1KLF4HB7RA000650", Adas = "0" },
        new CarStaticDetail { Id = 1037, CarId = 1037, Tag = "668", Finas = "X294-00461", Vin = "4JGGM1CB5PA000386", Adas = "0" },
        new CarStaticDetail { Id = 1038, CarId = 1038, Tag = "669", Finas = "X296-00322", Vin = "4JGDM2DB2PA000031", Adas = "0" },
        new CarStaticDetail { Id = 1039, CarId = 1039, Tag = "670", Finas = "V295-00503", Vin = "W1KEG2BB5PF000620", Adas = "0" }

                );


            modelBuilder.Entity<RoleEventMapping>()
     .HasKey(r => r.Id);
           // modelBuilder.Entity<BlankModel>()
//.HasKey(r => r.Id);



            modelBuilder.Entity<RoleEventMapping>()
        .HasIndex(r => r.Role)
        .IsUnique();

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.ApplicationUserDetail)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<ApplicationUserDetail>(b => b.UserId);

            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.ApplicationUser)
                .WithMany(u => u.UserEvents)
                .HasForeignKey(ue => ue.UserId)
                .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.SetNull);

            // relationship UserEventDetail and UserEvent entities
            modelBuilder.Entity<UserEventDetail>()
                .HasOne(ued => ued.UserEvent) // Specifies that a UserEventDetail has one UserEvent
                .WithMany(ue => ue.UserEventDetails) // Specifies that a UserEvent can have many UserEventDetails
                .HasForeignKey(ued => ued.UserEventDetailId); // Specifies UserEventDetailId as foreign key in this relationship

            // EventDetail and Event relationship
            modelBuilder.Entity<EventDetail>()
                .HasOne(ed => ed.Event)
                .WithMany(e => e.EventDetails)
                .HasForeignKey(ed => ed.EventId)
                .OnDelete(DeleteBehavior.Cascade); // Here, EventDetail is the dependent entity

            // Fluent API is used to configure the relationship between UserEvent and Event entities
            modelBuilder.Entity<UserEvent>() // Begin the configuration for the UserEvent entity
                .HasOne(ue => ue.Event) // Specifies that a UserEvent entity has one associated Event entity
                .WithMany(e => e.UserEvents) // Specifies that an Event entity can have many associated UserEvent entities
                .HasForeignKey(ue => ue.EventId) // Defines the foreign key for the relationship to be the EventId property of the UserEvent entity
                .OnDelete(DeleteBehavior.Cascade); // Configures the delete behavior so that when an Event entity is deleted, all its associated UserEvent entities are also deleted


            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(x => new { x.UserId, x.LoginProvider, x.Name });

            modelBuilder.Entity<ApplicationUser>()
            .HasOne(a => a.ApplicationUserDetail);

            modelBuilder.Entity<IdentityRole>().ToTable("AspNetRoles");

            modelBuilder.Entity<Car>().ToTable("Cars")
            .HasOne(c => c.CarStaticDetail)
            .WithOne(cd => cd.Car)
            .HasForeignKey<CarStaticDetail>(cd => cd.CarId);

            modelBuilder.Entity<CarStatus>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("CarStatus");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.StatusId).HasColumnName("StatusID");
                entity.Property(e => e.StatusTime).HasColumnType("datetime");

                entity.HasOne(d => d.Car).WithMany()
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarStatus__CarID__498EEC8D");

                entity.HasOne(d => d.Status).WithMany()
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarStatus__Statu__4A8310C6");
            });

            modelBuilder.Entity<CarStatusNew>(entity =>
            {
                entity.HasKey(e => e.StatusId).HasName("PK__CarStatu__C8EE2043D8294AF0");

                entity.ToTable("CarStatus_New");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");
                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId).HasName("PK__ErrorLog__358565CA8BB277F2");

                entity.ToTable("ErrorLog");

                entity.HasIndex(e => e.CarId, "IDX_ErrorLog_CarID");

                entity.Property(e => e.ErrorId).HasColumnName("ErrorID");
                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.ErrorDetails).HasMaxLength(255);
                entity.Property(e => e.ErrorNotes).HasMaxLength(255);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Event__7944C870D4DB1DAC");

                entity.ToTable("Event");

                entity.HasIndex(e => e.CarId, "IdX_Event_CarId");

                entity.HasIndex(e => e.EventTypeId, "IdX_Event_EventTypeId");

                entity.HasIndex(e => e.UserId, "IdX_Event_UserId");

                entity.Property(e => e.Id).HasColumnName("EventId");
                entity.Property(e => e.CarId).HasColumnName("CarId");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeId");
                entity.Property(e => e.StartTime).HasColumnType("datetime");
                entity.Property(e => e.UserId).HasColumnName("UserId");

                // Add missing properties
                entity.Property(e => e.Date).IsRequired().HasColumnType("datetime");
                entity.Property(e => e.Type).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.EventType).WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Event__EventType__1CBC4616");

                // Uncomment this if you have a User entity related to the Event entity
                //entity.HasOne(d => d.User).WithMany(p => p.Events)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Event__UserId__1BC821DD");
            });

            /*           entity.HasOne(d => d.UserId).WithMany(p => p.Events)
                             .HasForeignKey(d => d.UserId)
                             .OnDelete(DeleteBehavior.ClientSetNull)
                             .HasConstraintName("FK__Event__UserId__1BC821DD");*/
        

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.HasKey(e => e.EventTypeId).HasName("PK__EventTyp__A9216B1F734774DB");

                entity.ToTable("EventType");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
                entity.Property(e => e.Name).HasMaxLength(50);
            });
            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.LogId).HasName("PK__Log__5E5499A88878D432");

                entity.ToTable("Log");

                entity.Property(e => e.LogId).HasColumnName("LogID");
                entity.Property(e => e.LogMessage).HasMaxLength(255);
                entity.Property(e => e.LogTime)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
            });
            modelBuilder.Entity<Logger>(entity =>
            {
                entity.HasKey(e => e.LoggerId).HasName("PK__Logger__0ABCCA66A1861B17");

                entity.ToTable("Logger");

                entity.Property(e => e.LoggerId).HasColumnName("LoggerID");
                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.TypeLogger).HasMaxLength(50);

                entity.HasOne(d => d.Car).WithMany(p => p.Loggers)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Logger__CarID__5224328E");
            });
/*            modelBuilder.Entity<PlaceholderUserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId).HasName("PK__Placehol__8AFACE3A8A46317E");

                entity.ToTable("PlaceholderUserRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
                entity.Property(e => e.RoleName).HasMaxLength(50);
            });
*/            modelBuilder.Entity<Software>(entity =>
            {
                entity.HasKey(e => e.SoftwareId).HasName("PK__Software__25EDB8DCFDCE01A5");

                entity.ToTable("Software");

                entity.HasIndex(e => e.CarId, "IDX_Software_CarID");

                entity.Property(e => e.SoftwareId).HasColumnName("SoftwareID");
                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.HeadUnit).HasMaxLength(50);
                entity.Property(e => e.NextSoftwareVersion).HasMaxLength(50);
                entity.Property(e => e.SoftwareVersion).HasMaxLength(50);
            });
            modelBuilder.Entity<Source>(entity =>
            {
                entity.HasKey(e => e.SourceId).HasName("PK__Source__16E019F99EE16562");

                entity.ToTable("Source");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
                entity.Property(e => e.SourceName).HasMaxLength(50);
                //entity.Property(e => e.SourceType).HasMaxLength(50);
            });
            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusId).HasName("PK__Status__C8EE2043906DCC08");

                entity.ToTable("Status");

                entity.HasIndex(e => e.StatusName, "UQ_StatusName").IsUnique();

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");
                entity.Property(e => e.StatusName).HasMaxLength(50);
            });
            modelBuilder.Entity<TempErrorLog>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Temp_ErrorLog");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.ErrorDetails).HasMaxLength(255);
                entity.Property(e => e.ErrorId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ErrorID");
                entity.Property(e => e.ErrorNotes).HasMaxLength(255);
            });
            modelBuilder.Entity<TempEvent>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Temp_Event");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
                entity.Property(e => e.EventId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EventID");
                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
                entity.Property(e => e.StartTime).HasColumnType("datetime");
                entity.Property(e => e.UserId).HasColumnName("UserID");
            });
            modelBuilder.Entity<TempLogger>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Temp_Logger");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.LoggerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LoggerID");
                entity.Property(e => e.TypeLogger).HasMaxLength(50);
            });
            modelBuilder.Entity<TempRepair>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Temp_Repair");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.RepairDetails).HasMaxLength(255);
                entity.Property(e => e.RepairEnd).HasColumnType("datetime");
                entity.Property(e => e.RepairId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RepairID");
                entity.Property(e => e.RepairStart).HasColumnType("datetime");
                entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");
            });
            modelBuilder.Entity<TempSoftware>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Temp_Software");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.HeadUnit).HasMaxLength(50);
                entity.Property(e => e.NextSoftwareVersion).HasMaxLength(50);
                entity.Property(e => e.SoftwareId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SoftwareID");
                entity.Property(e => e.SoftwareVersion).HasMaxLength(50);
            });
            OnModelCreatingPartial(modelBuilder);
        }
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            // Enable lazy loading
            //builder.UseLazyLoadingProxies();

            // Enable sensitive data logging
            builder.EnableSensitiveDataLogging();

            return new ApplicationDbContext(builder.Options);
        }
    }


}







//partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

