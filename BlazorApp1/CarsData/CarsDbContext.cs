using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.CarModels;

public partial class CarsContext : DbContext
{
    public CarsContext()
    {
    }

    public CarsContext(DbContextOptions<CarsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarDetail> CarDetails { get; set; }

    public virtual DbSet<CarStatus> CarStatuses { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Logger> Loggers { get; set; }

    public virtual DbSet<PlaceholderUser> PlaceholderUsers { get; set; }

    public virtual DbSet<PlaceholderUserRole> PlaceholderUserRoles { get; set; }

    public virtual DbSet<Repair> Repairs { get; set; }

    public virtual DbSet<Software> Softwares { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<ViewByTag> ViewByTags { get; set; }

   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("Server=c138l0081334152;Database=Cars;User Id=sa;Password=QRD3de32882D!;TrustServerCertificate=true;Trusted_Connection=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__Car__68A0340EB8044FDF");

            entity.ToTable("Car", tb => tb.HasTrigger("car_insert_trigger"));

            entity.HasIndex(e => e.SourceId, "IDX_Car_SourceID");

            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.TeleGeneration).HasMaxLength(50);

            

            
        });

        modelBuilder.Entity<CarDetail>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CarId, "IDX_CarDetails_CarID");

            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.Finas)
                .HasMaxLength(10)
                .HasColumnName("FINAS");
            entity.Property(e => e.FullVin)
                .HasMaxLength(20)
                .HasColumnName("FullVIN");
            
            
            entity.Property(e => e.Tag)
                .HasMaxLength(10)
                .HasColumnName("TAG");
            entity.Property(e => e.Vinlast4)
                .HasMaxLength(10)
                .HasColumnName("VINLAST4");

            entity.HasOne(d => d.Car).WithMany()
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CarDetail__CarID__151B244E");
        });

        modelBuilder.Entity<CarStatus>(entity =>
        {

            entity.ToTable("CarStatus");

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

            entity.HasOne(d => d.Car).WithMany(p => p.ErrorLogs)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ErrorLog__CarID__17F790F9");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Event__7944C870D4DB1DAC");

            entity.ToTable("Event");

            entity.HasIndex(e => e.CarId, "IDX_Event_CarID");

            entity.HasIndex(e => e.EventTypeId, "IDX_Event_EventTypeID");

            entity.HasIndex(e => e.UserId, "IDX_Event_UserID");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Car).WithMany(p => p.Events)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Event__CarID__1AD3FDA4");

            entity.HasOne(d => d.EventType).WithMany(p => p.Events)
                .HasForeignKey(d => d.EventTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Event__EventType__1CBC4616");

            entity.HasOne(d => d.User).WithMany(p => p.Events)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Event__UserID__1BC821DD");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.HasKey(e => e.EventTypeId).HasName("PK__EventTyp__A9216B1F734774DB");

            entity.ToTable("EventType");

            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.EventTypeName).HasMaxLength(50);
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
            entity.HasKey(e => e.LoggerId).HasName("PK__Logger__0ABCCA66EFB22890");

            entity.ToTable("Logger");

            entity.HasIndex(e => e.CarId, "IDX_Logger_CarID");

            entity.Property(e => e.LoggerId).HasColumnName("LoggerID");
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.TypeLogger).HasMaxLength(50);

            
        });

        modelBuilder.Entity<PlaceholderUser>(entity =>
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
        });

        modelBuilder.Entity<PlaceholderUserRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Placehol__8AFACE3A8A46317E");

            entity.ToTable("PlaceholderUserRole");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<Repair>(entity =>
        {
            entity.HasKey(e => e.RepairId).HasName("PK__Repair__07D0BDCD7B794072");

            entity.ToTable("Repair");

            entity.HasIndex(e => e.CarId, "IDX_Repair_CarID");

            entity.HasIndex(e => e.TechnicianId, "IDX_Repair_TechnicianID");

            entity.Property(e => e.RepairId).HasColumnName("RepairID");
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.RepairDetails).HasMaxLength(255);
            entity.Property(e => e.RepairEnd).HasColumnType("datetime");
            entity.Property(e => e.RepairStart).HasColumnType("datetime");
            entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");

            

            entity.HasOne(d => d.Technician).WithMany(p => p.Repairs)
                .HasForeignKey(d => d.TechnicianId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Repair__Technici__2645B050");
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
            entity.Property(e => e.SourceType).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewByTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW - byTag");

            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.Finas)
                .HasMaxLength(10)
                .HasColumnName("FINAS");
            entity.Property(e => e.FullVin)
                .HasMaxLength(20)
                .HasColumnName("FullVIN");
            entity.Property(e => e.HarnessStatus)
                .HasMaxLength(50)
                .HasColumnName("HARNESS_STATUS");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.SoftwareVersion).HasMaxLength(20);
            entity.Property(e => e.Star3).HasColumnName("STAR3");
            entity.Property(e => e.Tag)
                .HasMaxLength(10)
                .HasColumnName("TAG");
            entity.Property(e => e.Vinlast4)
                .HasMaxLength(10)
                .HasColumnName("VINLAST4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
