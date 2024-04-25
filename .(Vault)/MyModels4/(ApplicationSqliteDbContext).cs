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

        /*public ApplicationSQLiteDbContext(DbContextOptions contextOptions)
            : base(contextOptions)
        {
        }*/

/*        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

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
        public virtual DbSet<MasterLog> MasterLogs { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<NoteEventDetail> NoteEventDetails { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<UserEventDetailGranular> UserEventDetails { get; set; }
        public virtual DbSet<UserEvent> UserEvents { get; set; }
        public virtual DbSet<RoleEventMapping> RoleEventMappings { get; set; }*/
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }
        public virtual DbSet<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; }
        public virtual DbSet<ExcelDataRecordAttribute> ExcelDataRecordAttributes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<EntityAttributeValue> EntityAttributeValues { get; set; }
        public virtual DbSet<BlazorApp1.CarModels.Order> Orders { get; set; }

       // partial void OnModelCreating(ModelBuilder modelBuilder);

       /* base.OnModelCreating(modelBuilder);

base.OnModelCreating(modelBuilder);*/

        //public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "C:\\Dev\\BlazorApp1\\BlazorApp1\\Data\\BlazorSQLite.db")
                .LogTo(Console.WriteLine); 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //new OrderMapConfiguration().Configure(modelBuilder.Entity<Order>());

            //modelBuilder.ApplyConfiguration(new OrderMapConfiguration());
            modelBuilder.ApplyConfiguration(new OrderMapConfiguration());



            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.ApplicationUserStaticDetail)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<ApplicationUserStaticDetail>(b => b.Id);
            modelBuilder.Entity<Blank>().HasData(
                new Blank { Id = 1, Name = "Item 1", String = "This is item 1 data" }
            );
            modelBuilder.Entity<ExcelDataRecord>()
           .HasMany(e => e.Attributes)
           .WithOne(a => a.ExcelDataRecord)
           .HasForeignKey(a => a.ExcelDataRecordId);

            modelBuilder.Entity<ExcelDataRecord>().HasData(
            new ExcelDataRecord
            {
                Id = 1,
                DataHash = "hash1",
                Data = "Data1",
                UploadDate = DateTime.Now,
                LastModified = DateTime.Now
            },
            new ExcelDataRecord
            {
                Id = 2,
                DataHash = "hash2",
                Data = "Data2",
                UploadDate = DateTime.Now,
                LastModified = DateTime.Now
            }
        );


            modelBuilder.Entity<ExcelDataRecordAttribute>().HasData(
                new ExcelDataRecordAttribute
                {
                    Id = -1,
                    ExcelDataRecordId = -1,
                    Name = "TestAttribute1",
                    Value = "TestValue1"
                },
                new ExcelDataRecordAttribute
                {
                    Id = -2,
                    ExcelDataRecordId = -1,
                    Name = "TestAttribute2",
                    Value = "TestValue2"
                },
                new ExcelDataRecordAttribute
                {
                    Id = -3,
                    ExcelDataRecordId = -2,
                    Name = "TestAttribute1",
                    Value = "TestValue1"
                },
                new ExcelDataRecordAttribute
                {
                    Id = -4,
                    ExcelDataRecordId = -2,
                    Name = "TestAttribute2",
                    Value = "TestValue2"
                }
            );

            /*modelBuilder.Entity<ExcelDataRecord>().HasData(
                new ExcelDataRecord
                {
                    Id = 1,
                   // Data = "Data1",
                    DataHash = "DataHash1",
                    UploadDate = DateTime.Now,
                    LastModified = DateTime.Now,
                    JsonData = "JsonData1",
                    Attributes 
                    // ProcessedColumns = new List<string> { "column1", "column2" },
                    // Seed data for Changes is not shown here as it depends on the structure of ExcelDataRecordChange
                },
                new ExcelDataRecord
                {
                    Id = 2,
                   // Data = "Data2",
                    DataHash = "DataHash2",
                    UploadDate = DateTime.Now,
                    LastModified = DateTime.Now,
                    JsonData = "JsonData2",
                    // ProcessedColumns = new List<string> { "column3", "column4" },
                    // Seed data for Changes is not shown here as it depends on the structure of ExcelDataRecordChange
                });*/
            /*modelBuilder.Entity<ExcelDataRecord>().HasData(
                    new ExcelDataRecord
                    {
                        Id = 1,  // Your value here
                        Data = "ExampleData",  // Your value here
                        DataHash = "ExampleDataHash",  // Your value here
                        UploadDate = DateTime.Now,  // Your value here
                        LastModified = DateTime.Now,  // Your value here }
                    });*/
            // Seed data for the "Blank" entity
            /*modelBuilder.Entity<Blank>().HasData(
                new Blank { Id = 1, Name = "Item 1", String = "This is item 1 data" }
            );*/

            // Seed data for the "Statuses" entity
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Available" },
                new Status { Id = 2, Name = "NotAvailable" },
                new Status { Id = 3, Name = "AwaitingAction" }

            );
            // Seed data for the "DetailTypes" entity
            modelBuilder.Entity<DetailType>().HasData(
                new DetailType { Id = 1, Name = "Ticket" },
                new DetailType { Id = 2, Name = "Car" },
                new DetailType { Id = 3, Name = "Event" },
                new DetailType { Id = 4, Name = "Ticket" },
                new DetailType { Id = 5, Name = "Shop" },
                new DetailType { Id = 6, Name = "Highlight" },
                new DetailType { Id = 7, Name = "Improvement" },
                new DetailType { Id = 8, Name = "Critique" }
            );

            // Seed data for the "Sources" entity
            modelBuilder.Entity<Source>().HasData(
                new Source { Id = 1, Name = "MarketBorrow" },
                new Source { Id = 2, Name = "Purchased" },
                new Source { Id = 3, Name = "Owned" }

            );

            // Seed data for the "TicketCategory" entity
            modelBuilder.Entity<TicketCategory>().HasData(
                new TicketCategory { Id = 1, Name = "Voca1", DefaultPriority = 1 },
                new TicketCategory { Id = 2, Name = "Voca2", DefaultPriority = 2 },
                new TicketCategory { Id = 3, Name = "Voca3", DefaultPriority = 3 }


            );

            // Seed data for the "EventTypes" entity
            modelBuilder.Entity<EventType>().HasData(
                new EventType { Id = 1, Name = "Comission" },
                new EventType { Id = 2, Name = "Decomission" },
                new EventType { Id = 3, Name = "TicketSubmission" },
                new EventType { Id = 4, Name = "ErrorIdentification" },
                new EventType { Id = 5, Name = "TestDrive" },
                new EventType { Id = 6, Name = "ShopConfiguration" },
                new EventType { Id = 7, Name = "PreparedForDrive" },
                new EventType { Id = 8, Name = "TagAssigned" },
                new EventType { Id = 9, Name = "TagUnAssigned" },
                new EventType { Id = 10, Name = "LoggerInstall" },
                new EventType { Id = 11, Name = "LoggerUnInstall" },
                new EventType { Id = 12, Name = "MainDriveEvent" },
                new EventType { Id = 13, Name = "RoutineDrive" }
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

            #region =====[ EventType Config & seed ]========================================home
            // Configure for EventType
            modelBuilder.Entity<EventType>()
                .HasKey(e => e.Id); // Configures Id as primary key
            modelBuilder.Entity<EventType>()
                .Property(e => e.Id).ValueGeneratedOnAdd(); // Makes Id auto increment
            modelBuilder.Entity<EventType>()
                .HasIndex(e => e.Name).IsUnique(); // Makes Name unique

            // Seed EventType
            modelBuilder.Entity<EventType>().HasData(
                new EventType { Id = 1001, Name = "Type1" },
                new EventType { Id = 1002, Name = "Type2" },
                new EventType { Id = 1003, Name = "Type3" }
            );
            #endregion
            #region =====[ DetailType Config & Seed ]========================================home


            // Configure for DetailType
            modelBuilder.Entity<DetailType>()
                .HasKey(e => e.Id); // Configures Id as primary key
            modelBuilder.Entity<DetailType>()
                .Property(e => e.Id).ValueGeneratedOnAdd(); // Makes Id auto increment
            modelBuilder.Entity<DetailType>()
                .HasIndex(e => e.Name).IsUnique(); // Makes Name unique

            // Seed DetailType
            modelBuilder.Entity<DetailType>().HasData(
                new DetailType { Id = 1001, Name = "Detail1" },
                new DetailType { Id = 1002, Name = "Detail2" },
                new DetailType { Id = 1003, Name = "Detail3" }
            );
            #endregion
            #region =====[ Source Config & seed ]========================================home
            // Configure for EventType
            modelBuilder.Entity<Source>()
                .HasKey(e => e.Id); // Configures Id as primary key
            modelBuilder.Entity<Source>()
                .Property(e => e.Id).ValueGeneratedOnAdd(); // Makes Id auto increment
            modelBuilder.Entity<Source>()
                .HasIndex(e => e.Name).IsUnique(); // Makes Name unique

            // Seed EventType
            modelBuilder.Entity<Source>().HasData(
                new Source { Id = 1001, Name = "MarketBorrow" },
                new Source { Id = 1002, Name = "Owned" },
                new Source { Id = 1003, Name = "Purchased" }
            );
            #endregion
            #region =====[ Car /StaticDetail Config & Seed ]========================================home
            //one to one with car independantly maintainable without CarStaticDetail
            //CarStaticDetail Accounted for via given a primary key thats the foriegnkey that references its Principal Objects Id (Car.Id is CarstaticDetails )
            modelBuilder.Entity<Car>()
                    .HasOne(e => e.CarStaticDetail)
            .WithOne(e => e.Car)
                    .HasForeignKey<CarStaticDetail>(e => e.Id)
                    .IsRequired(false);
            #endregion
            #region =====[ ApplicationUser ]========================================home

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.ApplicationUserStaticDetail)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<ApplicationUserStaticDetail>(b => b.Id);
            /*modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.ApplicationUserDetail)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<ApplicationUserDetail>(b => b.UserId);*/

            modelBuilder.Entity<ApplicationUser>()
        .HasOne(a => a.ApplicationUserStaticDetail)
        .WithOne(b => b.ApplicationUser)
        .HasForeignKey<ApplicationUserStaticDetail>(b => b.Id);
            #endregion

            modelBuilder.Entity<UserEvent>()
     .HasOne(ue => ue.ApplicationUser)
     .WithMany()
     .HasForeignKey(ue => ue.UserId);

            modelBuilder.Entity<ApplicationUserDetail>()
                .HasMany(ud => ud.UserEvents)
                .WithOne(ue => ue.ApplicationUserDetail);
            //.HasForeignKey(ue => ue.ApplicationUserDetail);


            modelBuilder.Entity<ApplicationUserDetail>()
    .HasMany(ud => ud.TicketsCreated)
    .WithOne(t => t.ApplicationApplicationUserDetails)
    .HasForeignKey(t => t.Id)
    .IsRequired();

            /*            modelBuilder.Entity<UserDetail>()
                            .HasMany(ud => ud.TicketHistories)
                            .WithOne(t => t.UserDetail);
                            //.HasForeignKey(t => t.Owner);*/


            modelBuilder.Entity<ApplicationUserDetail>()
                .HasOne(ud => ud.DriverStats)
                .WithOne(ds => ds.ApplicationUserDetail)
                .HasForeignKey<ApplicationUserDetail>(ud => ud.DriverStatsId);

            /*modelBuilder.Entity<UserDetail>()
                .HasMany(ud => ud.Timelines)
                .WithOne(tl => tl.UserDetail)
                .HasForeignKey(ApplicationUser => ApplicationUser.UserDetail);*/

            modelBuilder.Entity<Team>()
            .HasMany(t => t.TeamMembers)
            .WithOne(u => u.Team)
            .HasForeignKey(u => u.TeamId);

            modelBuilder.Entity<Team>()
            .HasOne(t => t.TeamTimeline)
            .WithOne(tt => tt.Team)
            .HasForeignKey<TeamTimeline>(tt => tt.TeamId);

           // OnModelCreating(modelBuilder);

        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationSQLiteDbContext>
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
        }

    }

}
