using BlazorApp1.CarModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Attribute = BlazorApp1.CarModels.Attribute;
using BlazorApp1.Mapping;
using System.Reflection.Metadata;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Design;
using DocumentFormat.OpenXml.InkML;

namespace BlazorApp1.Data
{
    public class ApplicationSQLiteDbContext : DbContext
    {
        public ApplicationSQLiteDbContext(DbContextOptions<ApplicationSQLiteDbContext> contextOptions)
            : base(contextOptions)
        {
        }

        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }
        public virtual DbSet<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; }
        public virtual DbSet<ExcelDataRecordAttribute> ExcelDataRecordAttributes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
       // public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<EntityAttributeValue> EntityAttributeValues { get; set; }
        public virtual DbSet<Order> Orders { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Dev\\BlazorApp1\\BlazorApp1\\Data\\BlazorSQLite.db")
                          .LogTo(Console.WriteLine);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //new OrderMapConfiguration().Configure(modelBuilder.Entity<Order>());

         //  modelBuilder.ApplyConfiguration(new OrderMap());
            //modelBuilder.ApplyConfiguration(new OrderMapConfiguration());



            /* modelBuilder.Entity<ApplicationUser>()
                 .HasOne(a => a.ApplicationUserStaticDetail)
                 .WithOne(b => b.ApplicationUser)
                 .HasForeignKey<ApplicationUserStaticDetail>(b => b.Id);*/

            modelBuilder.Entity<Blank>().HasData(
                new Blank { Id = 1, Name = "Item 1", String = "This is item 1 data" }
            );

            modelBuilder.Entity<ExcelDataRecord>()
           .HasMany(e => e.Attributes)
           .WithOne(a => a.ExcelDataRecord)
           .HasForeignKey(a => a.ExcelDataRecordId);

            modelBuilder.Entity<ExcelDataRecord>()
                .HasData(
            new ExcelDataRecord
            {
                Id = 1,
                Hash = "hash1",
                Data = "Data1",
                UploadDate = DateTime.Now,
                LastModified = DateTime.Now
            },
            new ExcelDataRecord
            {
                Id = 2,
                Hash = "hash2",
                Data = "Data2",
                UploadDate = DateTime.Now,
                LastModified = DateTime.Now
            }
                );


          /*  modelBuilder.Entity<ExcelDataRecordAttribute>()
                .HasData(
                new ExcelDataRecordAttribute
                {
                    Id = 1001,
                    ExcelDataRecordId = 1001,
                    Name = "TestAttribute1",
                    Value = "TestValue1"
                },
                new ExcelDataRecordAttribute
                {
                    Id = 1002,
                    ExcelDataRecordId = 1002,
                    Name = "TestAttribute2",
                    Value = "TestValue2"
                },
                new ExcelDataRecordAttribute
                {
                    Id = 1003,
                    ExcelDataRecordId = 1003,
                    Name = "TestAttribute1",
                    Value = "TestValue1"
                },
                new ExcelDataRecordAttribute
                {
                    Id = 1004,
                    ExcelDataRecordId = 1004,
                    Name = "TestAttribute2",
                    Value = "TestValue2"
                }
            );*/



            // Seed data for the "Statuses" entity
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1001, Name = "Available" },
                new Status { Id = 1002, Name = "NotAvailable" },
                new Status { Id = 1003, Name = "AwaitingAction" }

            );
            // Seed data for the "DetailTypes" entity
            modelBuilder.Entity<DetailType>().HasData(
                new DetailType { Id = 1001, Name = "Ticket" },
                new DetailType { Id = 1002, Name = "Car" },
                new DetailType { Id = 1003, Name = "UserCarEvent" },
                new DetailType { Id = 1004, Name = "Ticket" },
                new DetailType { Id = 1005, Name = "Shop" },
                new DetailType { Id = 1006, Name = "Highlight" },
                new DetailType { Id = 1007, Name = "Improvement" },
                new DetailType { Id = 1008, Name = "Critique" }
            );

            // Seed data for the "Sources" entity
            modelBuilder.Entity<Source>().HasData(
                new Source { Id = 1001, Name = "MarketBorrow" },
                new Source { Id = 1002, Name = "Purchased" },
                new Source { Id = 1003, Name = "Owned" }

            );

            // Seed data for the "TicketCategory" entity
            /* modelBuilder.Entity<TicketCategory>().HasData(
                 new TicketCategory { Id = 1001, Name = "Voca1", DefaultPriority = 1 },
                 new TicketCategory { Id = 1002, Name = "Voca2", DefaultPriority = 2 },
                 new TicketCategory { Id = 1003, Name = "Voca3", DefaultPriority = 3 }
             );*/

            // Seed data for the "EventTypes" entity
            modelBuilder.Entity<EventType>().HasData(
                new EventType { Id = 1001, Name = "Comission" },
                new EventType { Id = 1002, Name = "Decomission" },
                new EventType { Id = 1003, Name = "TicketSubmission" },
                new EventType { Id = 1004, Name = "ErrorIdentification" },
                new EventType { Id = 1005, Name = "TestDrive" },
                new EventType { Id = 1006, Name = "ShopConfiguration" },
                new EventType { Id = 1007, Name = "PreparedForDrive" },
                new EventType { Id = 1008, Name = "TagAssigned" },
                new EventType { Id = 1009, Name = "TagUnAssigned" },
                new EventType { Id = 1010, Name = "LoggerInstall" },
                new EventType { Id = 1011, Name = "LoggerUnInstall" },
                new EventType { Id = 1012, Name = "MainDriveEvent" },
                new EventType { Id = 1013, Name = "RoutineDrive" }
            );

            // Seed data for the "Logs" entity
            modelBuilder.Entity<MasterLog>().HasData(
                new MasterLog { Id = 1, Message = "App Birth.", Time = DateTime.Now },
                new MasterLog { Id = 2, Message = "Hello from The past.", Time = DateTime.Now }
            );


            modelBuilder.Entity<Team>().HasData(
            new Team { Id = 1, Name = "Unassigned" },
            new Team { Id = 2, Name = "Adas" },
            new Team { Id = 3, Name = "Telematics" }
            );


            //OnModelCreating(modelBuilder);

        }

       /* public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationSQLiteDbContext>
        {
            public ApplicationSQLiteDbContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<ApplicationSQLiteDbContext>();
                builder.UseSqlite(configuration.GetConnectionString("SqliteConnection"));

                // Enable lazy loading
                //builder.UseLazyLoadingProxies();

                // Enable sensitive data logging
                builder.EnableSensitiveDataLogging();

                return new ApplicationSQLiteDbContext(builder.Options);
            }
        }*/

    }

}
