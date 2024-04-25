using BlazorApp1.CarModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorApp1.Data
{
    /*public class ApplicationDbContext : DbContext, IDbContext
    {
        // Existing ApplicationDbContext implementation...
    }*/
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<CarStaticDetail> CarStaticDetails { get; set; }
        //
        public virtual DbSet<CarStatus> CarStatuses { get; set; }
        //
        public virtual DbSet<CarStatusNew> CarStatusNews { get; set; }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

        public virtual DbSet<Event> Events { get; set; }

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

        //public virtual DbSet<Software> Softwares { get;  set; }

        // public virtual DbSet<Issue> Issues { get; set; }

        //public virtual DbSet<Event> Events { get; set; }
        //public virtual DbSet<EventType> EventTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<ApplicationUser>()
         .HasOne(a => a.ApplicationUserDetail)
         .WithOne(b => b.ApplicationUser)
         .HasForeignKey<ApplicationUserDetail>(b => b.ApplicationUser.Id);*/

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
            modelBuilder.Entity<Car>()
    .HasOne(c => c.CarStaticDetail)
    .WithOne(cd => cd.Car)
    .HasForeignKey<CarStaticDetail>(cd => cd.CarId);
            modelBuilder.Entity<Car>()
    .HasOne(a => a.CarStaticDetail)
    .WithOne(b => b.Car)
    .HasForeignKey<CarStaticDetail>(b => b.CarId);
            /*modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.CarId).HasName("PK__Car__68A0340E718EAFE6");

                entity.ToTable("Car");

                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.Location).HasMaxLength(255);
                entity.Property(e => e.Make).HasMaxLength(50);
                entity.Property(e => e.Model).HasMaxLength(50);
                entity.Property(e => e.SourceId).HasColumnName("SourceID");
                entity.Property(e => e.TeleGeneration).HasMaxLength(50);
            });

            modelBuilder.Entity<CarStaticDetail>(entity =>
            {
                entity.HasKey(e => e.CarId).HasName("PK__CarStaticDetai__68A0340EDCEEBCE1");

                entity.Property(e => e.CarId)
                    .ValueGeneratedNever()
                    .HasColumnName("CarID");
                entity.Property(e => e.Adas)
                    .HasMaxLength(50)
                    .HasColumnName("ADAS");
                entity.Property(e => e.Finas).HasMaxLength(50);
                entity.Property(e => e.FullVin).HasMaxLength(50);
                entity.Property(e => e.HarnessStatus).HasMaxLength(50);
                entity.Property(e => e.SoftwareVersion).HasMaxLength(50);
                entity.Property(e => e.Tag).HasMaxLength(50);
                entity.Property(e => e.VinLast4).HasMaxLength(50);

                entity.HasOne(d => d.Car).WithOne(p => p.CarStaticDetail)
                    .HasForeignKey<CarStaticDetail>(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarStaticDetail__CarID__55009F39");
            });*/

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

                entity.HasIndex(e => e.CarId, "IDX_Event_CarID");

                entity.HasIndex(e => e.EventTypeId, "IDX_Event_EventTypeID");

                entity.HasIndex(e => e.UserId, "IDX_Event_UserID");

                entity.Property(e => e.Id).HasColumnName("EventID");
                entity.Property(e => e.CarId).HasColumnName("CarID");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
                entity.Property(e => e.StartTime).HasColumnType("datetime");
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.EventType).WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Event__EventType__1CBC4616");

                /*  object value = entity.HasOne(d => d.UserId).WithMany(p => p.Events)
                      .HasForeignKey(d => d.UserId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK__Event__UserID__1BC821DD");*/
            });

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

            /*modelBuilder.Entity<PlaceholderUser>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__Placehol__1788CCAC4A09DA10");

                entity.ToTable("PlaceholderUser");

                entity.HasIndex(e => e.RoleId, "IDX_PlaceholderUser_RoleID");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");
                entity.Property(e => e.Password).HasMaxLength(50);
                entity.Property(e => e.RoleId).HasColumnName("RoleID");
                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Role).WithMany(p => p.PlaceholderUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Placehold__RoleI__07C12930");
            });*/

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

