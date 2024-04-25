using BlazorApp1.CarModels;
using BlazorApp1.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BlazorApp1.Data
{

    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    //  public virtual DbSet<CalendarUserDto> CalendarUserDtos { get; set; }

    // public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }
    public virtual DbSet<CheckListItem> CheckListItems { get; set; }
    public virtual DbSet<TestRelease> TestReleases { get; set; }


    public virtual DbSet<MyModel> MyModels { get; set; }

        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Note> Notes { get; set; }

        public virtual DbSet<TaskModel> TaskModels { get; set; }
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }
        public virtual DbSet<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<NewCar> NewCars { get; set; }

        public virtual DbSet<CarDetail> CarDetails { get; set; }
        //


        //private readonly StreamWriter _logStream = new StreamWriter("C:\\Users\\Don\\Desktop\\mylog.txt", append: true);

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
        public virtual DbSet<RoleEventMapping> RoleEventMappings { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            //modelBuilder.ApplyConfiguration(new TeamTypeMap());
            modelBuilder.ApplyConfiguration(new TeamTimelineMap());
            modelBuilder.ApplyConfiguration(new UserCarEventMap());
            modelBuilder.ApplyConfiguration(new EventMap());

            //modelBuilder.Entity<CalendarUserDto>().HasData(
            //new CalendarUserDto { CalendarUserDtoId = "1",FriendlyName = "Tim" },
            //new CalendarUserDto { CalendarUserDtoId = "2",FriendlyName = "Andreas" },
            //new CalendarUserDto { CalendarUserDtoId = "3",FriendlyName = "Martin" },
            //new CalendarUserDto { CalendarUserDtoId = "4",FriendlyName = "Shannon" },
            //new CalendarUserDto { CalendarUserDtoId = "5",FriendlyName = "Lamar" },
            //new CalendarUserDto { CalendarUserDtoId = "6",FriendlyName = "Donovan" },
            //new CalendarUserDto { CalendarUserDtoId = "7",FriendlyName = "Nathaniel" },
            //new CalendarUserDto { CalendarUserDtoId = "8",FriendlyName = "Charlie" },
            //new CalendarUserDto { CalendarUserDtoId = "9", FriendlyName = "Sawyer"},
            //            new CalendarUserDto { FriendlyName = "Hendrik", CalendarUserDtoId = "10" }

            // ... other users ...
        //);


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
                // {
                entity.HasKey(e => e.Id));


            modelBuilder.Entity<Event>()
            .HasOne(e => e.SimpleEventType) // The navigation property
            .WithMany()
            .HasForeignKey(e => e.SimpleEventTypeId) // The foreign key
            .IsRequired(false); // Not enforcing constraint





            modelBuilder.Entity<Software>(entity =>
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


            OnModelCreatingPartial(modelBuilder);

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .LogTo(Console.WriteLine, LogLevel.Information)
            .LogTo(Console.WriteLine, new[] { CoreEventId.ContextDisposed, CoreEventId.ContextInitialized })
            .LogTo(Console.WriteLine, new[] { CoreEventId.ContextDisposed, CoreEventId.ContextInitialized });

        public override void Dispose()
        {
            base.Dispose();
            //_logStream.DisposeAsync();
        }
        
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


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

            builder.EnableSensitiveDataLogging();

            return new ApplicationDbContext(builder.Options);
        }
    }


}







//partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

