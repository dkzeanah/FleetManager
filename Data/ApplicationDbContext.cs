using BlazorApp1.CarModels;
using BlazorApp1.CarModels.Mapping;
using BlazorApp1.Data.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Radzen;

namespace BlazorApp1.Data
{

    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TaskModel> TaskModels { get; set; }
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }
        public virtual DbSet<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<NewCar> NewCars { get; set; }

        public virtual DbSet<CarDetail> CarDetails { get; set; }
        //


        //private readonly StreamWriter _logStream = new StreamWriter("C:\\Users\\Don\\Desktop\\mylog.txt", append: true);

        public virtual DbSet<CarStatus> CarStatuses { get; set; }
        //
        public virtual DbSet<CarStatusNew> CarStatusNews { get; set; }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<SimpleEventType> SimpleEventTypes { get; set; }

        public virtual DbSet<EventType> EventTypes { get; set; }

        public virtual DbSet<Log> Logs { get; set; }

        public virtual DbSet<Logger> Loggers { get; set; }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        /*        public virtual DbSet<PlaceholderUserRole> PlaceholderUserRoles { get; set; }
        */
        public virtual DbSet<Software> Softwares { get; set; }

        public virtual DbSet<Source> Sources { get; set; }

        public virtual DbSet<Status> Statuses { get; set; }
        //public virtual DbSet<MyModel> MyModels { get; set; }
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

            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new TruckMap());
            // modelBuilder.ApplyConfiguration(new ApplicationUserRolesMap());

            modelBuilder.ApplyConfiguration(new BlankMap());
            modelBuilder.ApplyConfiguration(new CarMap());

            modelBuilder.ApplyConfiguration(new NewCarMap());

            modelBuilder.ApplyConfiguration(new DetailTypeMap());
            /*            modelBuilder.ApplyConfiguration(new SimpleEventTypeMap());
            */
            modelBuilder.ApplyConfiguration(new ExcelMap());
            modelBuilder.ApplyConfiguration(new LogMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new SimpleEventMap());
            modelBuilder.ApplyConfiguration(new SourceMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new TeamMap());
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

            // relationship UserEventDetail and UserEvent entities
    /*        modelBuilder.Entity<UserEventDetail>()
                .HasOne(ued => ued.UserEvent) // Specifies that a UserEventDetail has one UserEvent
                .WithMany(ue => ue.UserEventDetails) // Specifies that a UserEvent can have many UserEventDetails
                .HasForeignKey(ued => ued.UserEventDetailId); // Specifies UserEventDetailId as foreign key in this relationship
*/
            // EventDetail and Event relationship
           /* modelBuilder.Entity<EventDetail>()
                .HasOne(ed => ed.Event)
                .WithMany(e => e.EventDetails)
                .HasForeignKey(ed => ed.EventId)
                .OnDelete(DeleteBehavior.Cascade); // Here, EventDetail is the dependent entity*/

            // Fluent API is used to configure the relationship between UserEvent and Event entities
           /* modelBuilder.Entity<UserEvent>() // Begin the configuration for the UserEvent entity
                .HasOne(ue => ue.Event) // Specifies that a UserEvent entity has one associated Event entity
                .WithMany(e => e.UserEvents) // Specifies that an Event entity can have many associated UserEvent entities
                .HasForeignKey(ue => ue.EventId) // Defines the foreign key for the relationship to be the EventId property of the UserEvent entity
                .OnDelete(DeleteBehavior.Cascade); // Configures the delete behavior so that when an Event entity is deleted, all its associated UserEvent entities are also deleted
*/

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




            modelBuilder.Entity<PlaceholderUserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId).HasName("PK__Placehol__8AFACE3A8A46317E");

                entity.ToTable("PlaceholderUserRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

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
        
      /*  public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            //await _logStream.DisposeAsync();
        }*/
        //{
        //base.OnConfiguring(optionsBuilder);
        //}
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

            // Enable lazy loading
            //builder.UseLazyLoadingProxies();

            // Enable sensitive data logging
            builder.EnableSensitiveDataLogging();

            return new ApplicationDbContext(builder.Options);
        }
    }


}







//partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

