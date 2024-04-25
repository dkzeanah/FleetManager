using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Data.Mapping;
using BlazorApp1.Mapping;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace BlazorApp1.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<UserEvent> UserEvents { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<UserCarEvent> UserCarEvents { get; set; }
        public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }
        public virtual DbSet<ExcelDataRecordAttribute> ExcelDataRecordAttributes { get; set; }
        public virtual DbSet<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        //public virtual DbSet<Cartag> Cartags { get; set; }
       // public virtual DbSet<CarStatus> CarStatuses { get; set; }
       // public virtual DbSet<Driver> Drivers { get; set; }
       // public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        //public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<MasterLog> MasterLogs { get; set; }
       // public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<RoleEventMapping> RoleEventMappings { get; set; }
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.LogTo(Console.WriteLine);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IdentityRole>().ToTable("AspNetRoles");


            modelBuilder.ApplyConfiguration(new ApplicationUserMap());
            modelBuilder.ApplyConfiguration(new BlankMap());

            modelBuilder.ApplyConfiguration(new CarMap());

            modelBuilder.ApplyConfiguration(new DetailTypeMap());

            modelBuilder.ApplyConfiguration(new EventMap());
            modelBuilder.ApplyConfiguration(new UserEventMap());

            modelBuilder.ApplyConfiguration(new EventTypeMap());
            modelBuilder.ApplyConfiguration(new ExcelMap());
            modelBuilder.ApplyConfiguration(new LogMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new RoleEventMappingMap());
            modelBuilder.ApplyConfiguration(new SourceMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new TeamMap());
            modelBuilder.ApplyConfiguration(new TeamTimelineMap());
            modelBuilder.ApplyConfiguration(new TicketCategoryMap());
            modelBuilder.ApplyConfiguration(new EventMap());


            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(x => new { x.UserId, x.LoginProvider, x.Name });












            ;



            /*
             event has many users, with many events 
                 id
                 List<user
                  List<userevent
             user
                 id
                    list<event
                    list<userever>
            userevent
             int EventId
             int UserId

             public datetime createdOn
             */



            /*      modelBuilder.Entity<UserEvent>()
                 .HasOne(ue => ue.ApplicationUser)
                 .WithMany()
                 .HasForeignKey(ue => ue.UserId);*/

            /*     modelBuilder.Entity<ApplicationUserDetail>()
                .HasMany(ud => ud.TicketsCreated)
                .WithOne(t => t.ApplicationApplicationUserDetails)
                .HasForeignKey(t => t.Id)
                .IsRequired();*/

            /*            modelBuilder.Entity<ApplicationUserDetail>()
                            .HasOne(ud => ud.DriverStats)
                            .WithOne(ds => ds.ApplicationUserDetail)
                            .HasForeignKey<ApplicationUserDetail>(ud => ud.DriverStatsId);
            */















            /* // relationship UserEventDetail and UserEvent entities
             modelBuilder.Entity<UserEventDetail>()
                 .HasOne(ued => ued.UserEventDetail) // Specifies that a UserEventDetail has one UserEvent
                 .WithMany(ue => ue.UserEventDetailGranulars) // Specifies that a UserEvent can have many UserEventDetails
                 .HasForeignKey(ued => ued.UserEventDetailId); // Specifies UserEventDetailId as foreign key in this relationship

             // EventDetail and UserCarEvent relationship
             modelBuilder.Entity<UserEventDetail>()
                 .HasOne(ed => ed.UserEvent)
                 .WithMany(e => e.UserEventDetails)
                 .HasForeignKey(ed => ed.UserEventId)
                 .OnDelete(DeleteBehavior.Cascade);

             // Fluent API is used to configure the relationship between UserEvent and UserCarEvent entities

             



             modelBuilder.Entity<IdentityRole>().ToTable("AspNetRoles");*/





            OnModelCreatingPartial(modelBuilder);
            //});
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
}











//partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

