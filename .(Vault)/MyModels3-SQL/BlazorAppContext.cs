using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.MyModels3;

public partial class BlazorAppContext : DbContext
{
    public BlazorAppContext()
    {
    }

    public BlazorAppContext(DbContextOptions<BlazorAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<ApplicationUserDetail> ApplicationUserDetails { get; set; }

    public virtual DbSet<ApplicationUserStaticDetail> ApplicationUserStaticDetails { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<Blank> Blanks { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Car2> Car2s { get; set; }

    public virtual DbSet<CarDetail> CarDetails { get; set; }

    public virtual DbSet<CarEvent> CarEvents { get; set; }

    public virtual DbSet<CarEventDetail> CarEventDetails { get; set; }

    public virtual DbSet<CarStaticDetail> CarStaticDetails { get; set; }

    public virtual DbSet<CarStatus> CarStatuses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<DetailType> DetailTypes { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<DriverStat> DriverStats { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<Issue> Issues { get; set; }

    public virtual DbSet<Logger> Loggers { get; set; }

    public virtual DbSet<MasterLog> MasterLogs { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleClaim> RoleClaims { get; set; }

    public virtual DbSet<RoleEventMapping> RoleEventMappings { get; set; }

    public virtual DbSet<Software> Softwares { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamTimeline> TeamTimelines { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketAttachment> TicketAttachments { get; set; }

    public virtual DbSet<TicketCategory> TicketCategories { get; set; }

    public virtual DbSet<TicketComment> TicketComments { get; set; }

    public virtual DbSet<TicketHistory> TicketHistories { get; set; }

    public virtual DbSet<TicketTag> TicketTags { get; set; }

    public virtual DbSet<Timeline> Timelines { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserEvent> UserEvents { get; set; }

    public virtual DbSet<UserEventDetail> UserEventDetails { get; set; }

    public virtual DbSet<UserEventDetailText> UserEventDetailTexts { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=BlazorApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.ToTable("ApplicationUser");

            entity.HasIndex(e => e.TeamId, "IX_ApplicationUser_TeamId");

            entity.HasOne(d => d.Team).WithMany(p => p.ApplicationUsers).HasForeignKey(d => d.TeamId);
        });

        modelBuilder.Entity<ApplicationUserDetail>(entity =>
        {
            entity.ToTable("ApplicationUserDetail");

            entity.HasIndex(e => e.ApplicationUserId, "IX_ApplicationUserDetail_ApplicationUserId").IsUnique();

            entity.HasIndex(e => e.DetailId, "IX_ApplicationUserDetail_DetailId");

            entity.HasIndex(e => e.DriverStatsId, "IX_ApplicationUserDetail_DriverStatsId")
                .IsUnique()
                .HasFilter("([DriverStatsId] IS NOT NULL)");

            entity.HasOne(d => d.ApplicationUser).WithOne(p => p.ApplicationUserDetail)
                .HasForeignKey<ApplicationUserDetail>(d => d.ApplicationUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Detail).WithMany(p => p.ApplicationUserDetails).HasForeignKey(d => d.DetailId);

            entity.HasOne(d => d.DriverStats).WithOne(p => p.ApplicationUserDetail).HasForeignKey<ApplicationUserDetail>(d => d.DriverStatsId);
        });

        modelBuilder.Entity<ApplicationUserStaticDetail>(entity =>
        {
            entity.ToTable("ApplicationUserStaticDetail");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ApplicationUserStaticDetail).HasForeignKey<ApplicationUserStaticDetail>(d => d.Id);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AspNetRole).HasForeignKey<AspNetRole>(d => d.Id);
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasIndex(e => e.SoftwareId, "IX_Cars_SoftwareId");

            entity.HasIndex(e => e.SourceId, "IX_Cars_SourceId");

            entity.HasOne(d => d.Software).WithMany(p => p.Cars).HasForeignKey(d => d.SoftwareId);

            entity.HasOne(d => d.Source).WithMany(p => p.Cars).HasForeignKey(d => d.SourceId);
        });

        modelBuilder.Entity<Car2>(entity =>
        {
            entity.HasIndex(e => e.CarStaticDetailId, "IX_Car2s_CarStaticDetailId");

            entity.HasOne(d => d.CarStaticDetail).WithMany(p => p.Car2s).HasForeignKey(d => d.CarStaticDetailId);
        });

        modelBuilder.Entity<CarDetail>(entity =>
        {
            entity.ToTable("CarDetail");

            entity.HasIndex(e => e.CarEventId, "IX_CarDetail_CarEventId");

            entity.HasIndex(e => e.CarId, "IX_CarDetail_CarId");

            entity.HasIndex(e => e.DetailId, "IX_CarDetail_DetailId");

            entity.HasOne(d => d.CarEvent).WithMany(p => p.CarDetails)
                .HasForeignKey(d => d.CarEventId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Car).WithMany(p => p.CarDetails).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Detail).WithMany(p => p.CarDetails).HasForeignKey(d => d.DetailId);
        });

        modelBuilder.Entity<CarEvent>(entity =>
        {
            entity.ToTable("CarEvent");

            entity.HasIndex(e => e.CarId, "IX_CarEvent_CarId");

            entity.HasIndex(e => e.EventId, "IX_CarEvent_EventId");

            entity.HasOne(d => d.Car).WithMany(p => p.CarEvents)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Event).WithMany(p => p.CarEvents)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CarEventDetail>(entity =>
        {
            entity.ToTable("CarEventDetail");

            entity.HasIndex(e => e.CarDetailId, "IX_CarEventDetail_CarDetailId");

            entity.HasIndex(e => e.CarEventId, "IX_CarEventDetail_CarEventId");

            entity.HasOne(d => d.CarDetail).WithMany(p => p.CarEventDetails).HasForeignKey(d => d.CarDetailId);

            entity.HasOne(d => d.CarEvent).WithMany(p => p.CarEventDetails)
                .HasForeignKey(d => d.CarEventId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CarStaticDetail>(entity =>
        {
            entity.HasIndex(e => e.CarId, "IX_CarStaticDetails_CarId")
                .IsUnique()
                .HasFilter("([CarId] IS NOT NULL)");

            entity.HasOne(d => d.Car).WithOne(p => p.CarStaticDetail).HasForeignKey<CarStaticDetail>(d => d.CarId);
        });

        modelBuilder.Entity<CarStatus>(entity =>
        {
            entity.HasIndex(e => e.CarId, "IX_CarStatuses_CarId");

            entity.HasIndex(e => e.StatusId, "IX_CarStatuses_StatusId");

            entity.HasOne(d => d.Car).WithMany(p => p.CarStatuses).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Status).WithMany(p => p.CarStatuses).HasForeignKey(d => d.StatusId);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");
        });

        modelBuilder.Entity<Detail>(entity =>
        {
            entity.ToTable("Detail");

            entity.HasIndex(e => e.ApplicationUserId, "IX_Detail_ApplicationUserId");

            entity.HasIndex(e => e.DetailTypeId, "IX_Detail_DetailTypeId");

            entity.HasIndex(e => e.UserEventDetailId, "IX_Detail_UserEventDetailId");

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.Details).HasForeignKey(d => d.ApplicationUserId);

            entity.HasOne(d => d.DetailType).WithMany(p => p.Details).HasForeignKey(d => d.DetailTypeId);

            entity.HasOne(d => d.UserEventDetail).WithMany(p => p.Details)
                .HasForeignKey(d => d.UserEventDetailId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<DetailType>(entity =>
        {
            entity.HasIndex(e => e.CarDetailId, "IX_DetailTypes_CarDetailId");

            entity.HasIndex(e => e.Name, "IX_DetailTypes_Name").IsUnique();

            entity.HasOne(d => d.CarDetail).WithMany(p => p.DetailTypes).HasForeignKey(d => d.CarDetailId);
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.Property(e => e.DrivingHours).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasIndex(e => e.CarId, "IX_Events_CarId");

            entity.HasIndex(e => e.CategoryId, "IX_Events_CategoryId");

            entity.HasIndex(e => e.EventTypeId, "IX_Events_EventTypeId");

            entity.HasIndex(e => e.TeamTimelineId, "IX_Events_TeamTimelineId");

            entity.HasIndex(e => e.TimelineId, "IX_Events_TimelineId");

            entity.HasIndex(e => e.UserId, "IX_Events_UserId");

            entity.HasOne(d => d.Car).WithMany(p => p.Events).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Category).WithMany(p => p.Events).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.EventType).WithMany(p => p.Events).HasForeignKey(d => d.EventTypeId);

            entity.HasOne(d => d.TeamTimeline).WithMany(p => p.Events).HasForeignKey(d => d.TeamTimelineId);

            entity.HasOne(d => d.Timeline).WithMany(p => p.Events).HasForeignKey(d => d.TimelineId);

            entity.HasOne(d => d.User).WithMany(p => p.Events).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_EventTypes_Name").IsUnique();
        });

        modelBuilder.Entity<Logger>(entity =>
        {
            entity.HasIndex(e => e.Car2Id, "IX_Loggers_Car2Id");

            entity.HasIndex(e => e.CarId, "IX_Loggers_CarId");

            entity.HasOne(d => d.Car2).WithMany(p => p.Loggers).HasForeignKey(d => d.Car2Id);

            entity.HasOne(d => d.Car).WithMany(p => p.Loggers).HasForeignKey(d => d.CarId);
        });

        modelBuilder.Entity<RoleEventMapping>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_RoleEventMappings_RoleId").IsUnique();
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_Sources_Name").IsUnique();
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.ToTable("Team");
        });

        modelBuilder.Entity<TeamTimeline>(entity =>
        {
            entity.ToTable("TeamTimeline");

            entity.HasIndex(e => e.TeamId, "IX_TeamTimeline_TeamId").IsUnique();

            entity.HasOne(d => d.Team).WithOne(p => p.TeamTimeline).HasForeignKey<TeamTimeline>(d => d.TeamId);
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasIndex(e => e.AssigneeId, "IX_Tickets_AssigneeId");

            entity.HasIndex(e => e.CreatorId, "IX_Tickets_CreatorId");

            entity.Property(e => e.ApplicationUserDetailId)
                .HasMaxLength(450)
                .HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Assignee).WithMany(p => p.TicketAssignees).HasForeignKey(d => d.AssigneeId);

            entity.HasOne(d => d.Creator).WithMany(p => p.TicketCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TicketAttachment>(entity =>
        {
            entity.ToTable("TicketAttachment");

            entity.Property(e => e.TicketId1)
                .HasMaxLength(450)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TicketCategory>(entity =>
        {
            entity.ToTable("TicketCategory");
        });

        modelBuilder.Entity<TicketComment>(entity =>
        {
            entity.ToTable("TicketComment");

            entity.HasIndex(e => e.AuthorId, "IX_TicketComment_AuthorId");

            entity.Property(e => e.TicketId1)
                .HasMaxLength(450)
                .HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Author).WithMany(p => p.TicketComments)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TicketHistory>(entity =>
        {
            entity.ToTable("TicketHistory");

            entity.HasIndex(e => e.OwnerId, "IX_TicketHistory_OwnerId");

            entity.Property(e => e.TicketId1)
                .HasMaxLength(450)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserDetailId1)
                .HasMaxLength(450)
                .HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Owner).WithMany(p => p.TicketHistories)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TicketTag>(entity =>
        {
            entity.ToTable("TicketTag");
        });

        modelBuilder.Entity<Timeline>(entity =>
        {
            entity.ToTable("Timeline");

            entity.HasIndex(e => e.ApplicationUserDetailId, "IX_Timeline_ApplicationUserDetailId");

            entity.Property(e => e.ApplicationUserDetailId).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<UserEvent>(entity =>
        {
            entity.HasIndex(e => e.ApplicationUserDetailId, "IX_UserEvents_ApplicationUserDetailId");

            entity.HasIndex(e => e.EventId, "IX_UserEvents_EventId");

            entity.HasIndex(e => e.UserId, "IX_UserEvents_UserId");

            entity.Property(e => e.ApplicationUserDetailId).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Event).WithMany(p => p.UserEvents).HasForeignKey(d => d.EventId);

            entity.HasOne(d => d.User).WithMany(p => p.UserEvents)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserEventDetail>(entity =>
        {
            entity.ToTable("UserEventDetail");

            entity.HasIndex(e => e.ApplicationUserId, "IX_UserEventDetail_ApplicationUserId");

            entity.HasIndex(e => e.CarId, "IX_UserEventDetail_CarId");

            entity.HasIndex(e => e.DetailId, "IX_UserEventDetail_DetailId");

            entity.HasIndex(e => e.EventId, "IX_UserEventDetail_EventId");

            entity.HasIndex(e => e.UserEventId, "IX_UserEventDetail_UserEventId");

            entity.HasIndex(e => e.UserId, "IX_UserEventDetail_UserId");

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.UserEventDetailApplicationUsers)
                .HasForeignKey(d => d.ApplicationUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Car).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Detail).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.DetailId);

            entity.HasOne(d => d.Event).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.EventId);

            entity.HasOne(d => d.UserEvent).WithMany(p => p.UserEventDetails)
                .HasForeignKey(d => d.UserEventId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.UserEventDetailUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserEventDetailText>(entity =>
        {
            entity.ToTable("UserEventDetailText");

            entity.HasIndex(e => e.UserEventDetailId, "IX_UserEventDetailText_UserEventDetailId");

            entity.HasOne(d => d.UserEventDetail).WithMany(p => p.UserEventDetailTexts)
                .HasForeignKey(d => d.UserEventDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
