
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
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Sqlite
{
    public partial class ApplicationSqliteDbContext : DbContext
    {
        public ApplicationSqliteDbContext(DbContextOptions<ApplicationSqliteDbContext> contextOptions)
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

        //from AppDbCtx
        public virtual DbSet<YourSensorDataModel> SensorData { get; set; }

        // public virtual DbSet<SensorDataModel> SensorDataModel { get; set; }

        public virtual DbSet<CheckListItem> CheckListItems { get; set; }
        public virtual DbSet<TestRelease> TestReleases { get; set; }
        public virtual DbSet<MyModel> MyModels { get; set; }

        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }



        public virtual DbSet<TaskModel> TaskModels { get; set; }


        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<NewCar> NewCars { get; set; }

        public virtual DbSet<CarDetail> CarDetails { get; set; }
        //


        private readonly StreamWriter _logStream = new StreamWriter("C:\\Users\\zeanahd\\Desktop\\mylog.txt", append: true);

        // public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<CarModule> CarModules { get; set; }
        public virtual DbSet<CarStatus> CarStatuses { get; set; }
        //
        public virtual DbSet<CarStatusNew> CarStatusNews { get; set; }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<SimpleEventType> SimpleEventTypes { get; set; }

        public virtual DbSet<EventType> EventTypes { get; set; }

        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<NewCarLogger> NewCarLoggers { get; set; }
        public virtual DbSet<NewTruckLogger> NewTruckLoggers { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<UserEventDetail> UserEventDetails { get; set; }
        public virtual DbSet<UserEvent> UserEvents { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<NoteEventDetail> NoteEventDetails { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<PostTag> PostTags { get; set; }
        public virtual DbSet<RoleEventMapping> RoleEventMappings { get; set; }




      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("C:\\Dev\\BlazorApplication-master\\BlazorApp1\\ContactsDb.db")
                          .LogTo(Console.WriteLine);
        }*/



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new OrderMap().Configure(modelBuilder.Entity<Order>());

            modelBuilder.ApplyConfiguration(new OrderMap());






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
                new DetailType { Id = 1003, Name = "Event" },
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
/*            modelBuilder.Entity<EventType>().HasData(
                new EventType { Id = 1001, Name = "Comission" },
                new EventType { Id = 1002, Name = "Decomission" },
                new EventType { Id = 1003, Name = "TicketSubmission" },
                new EventType { Id = 1004, Name = "Error Identification" },
                new EventType { Id = 1005, Name = "Test Drive" },
                new EventType { Id = 1006, Name = "Shop Configuration" },
                new EventType { Id = 1007, Name = "Prepared For Drive" },
                new EventType { Id = 1008, Name = "Tag Assigned" },
                new EventType { Id = 1009, Name = "Tag UnAssigned" },
                new EventType { Id = 1010, Name = "Logger Install" },
                new EventType { Id = 1011, Name = "Logger UnInstall" },
                new EventType { Id = 1012, Name = "Main DriveEvent" },
                new EventType { Id = 1013, Name = "Routine Drive" }
            );*/

            // Seed data for the "Logs" entity
          //  modelBuilder.Entity<MasterLog>().HasData(
           //     new MasterLog { Id = 1, Message = "App Birth.", Time = DateTime.Now },
           //     new MasterLog { Id = 2, Message = "Hello from The past.", Time = DateTime.Now }
          //  );


           /* modelBuilder.Entity<TeamTypes>().HasData(
            new TeamTypes { TeamTypesId = 1, Name = "Unassigned" },
            new TeamTypes { Id = 2, Name = "Adas" },
            new TeamTypes { Id = 3, Name = "Telematics" }
            );*/


            //from AppDbCtx
            modelBuilder.ApplyConfiguration(new ApplicationUserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new SimpleEventTypeMap());

            modelBuilder.ApplyConfiguration(new EventTypeMap());
            modelBuilder.ApplyConfiguration(new DetailTypeMap());
            modelBuilder.ApplyConfiguration(new SimpleEventMap());


            // modelBuilder.ApplyConfiguration(new ApplicationUserRolesMap());

            modelBuilder.ApplyConfiguration(new BlankMap());
            modelBuilder.ApplyConfiguration(new ExcelMap());
            modelBuilder.ApplyConfiguration(new LogMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new SourceMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new LoggerMap());




            modelBuilder.ApplyConfiguration(new NewCarMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new TruckMap());
            /*            modelBuilder.ApplyConfiguration(new SimpleEventTypeMap());
            */
            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new CarDetailMap());
           // modelBuilder.ApplyConfiguration(new TeamTypeMap());
            modelBuilder.ApplyConfiguration(new TeamTimelineMap());
            modelBuilder.ApplyConfiguration(new UserCarEventMap());
            modelBuilder.ApplyConfiguration(new EventMap());



            modelBuilder.Entity<ApplicationUser>()
    .HasOne(a => a.ApplicationUserDetail)
    .WithOne(b => b.ApplicationUser)
    .HasForeignKey<ApplicationUserDetail>(b => b.UserId);

            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.ApplicationUser)
                .WithMany(u => u.UserEvents)
                .HasForeignKey(ue => ue.UserId)
                .OnDelete(DeleteBehavior.Restrict); // or .OnDelete(DeleteBehavior.SetNull);



            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(x => new { x.UserId, x.LoginProvider, x.Name });

            modelBuilder.Entity<ApplicationUser>()
                 .HasOne(a => a.ApplicationUserDetail);

            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            //.HasIndex(e => e.Name).IsUnique();


            modelBuilder.Entity<Car>()
                .HasOne(c => c.CarDetail)
                .WithOne(cd => cd.Car)
                .HasForeignKey<CarDetail>(cd => cd.CarId);



           


            //OnModelCreating(modelBuilder);

        }



    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationSqliteDbContext>
    {
        public ApplicationSqliteDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationSqliteDbContext>();
            var connectionString = configuration.GetConnectionString("SqliteConnection"); // Assuming you have a connection string named "SqliteConnection" in appsettings.json
            builder.UseSqlite(connectionString);

            // Enable sensitive data logging if needed
            // builder.EnableSensitiveDataLogging();

            return new ApplicationSqliteDbContext(builder.Options);
        }
    }

}

