using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.MyModels1;

public partial class BlazorSqliteContext : DbContext
{
    public BlazorSqliteContext()
    {
    }

    public BlazorSqliteContext(DbContextOptions<BlazorSqliteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<ApplicationUserDetail> ApplicationUserDetails { get; set; }

    public virtual DbSet<ApplicationUserStaticDetail> ApplicationUserStaticDetails { get; set; }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<Blank> Blanks { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarDetail> CarDetails { get; set; }

    public virtual DbSet<CarEvent> CarEvents { get; set; }

    public virtual DbSet<CarEventDetail> CarEventDetails { get; set; }

    public virtual DbSet<CarStaticDetail> CarStaticDetails { get; set; }

    public virtual DbSet<CarStatus> CarStatuses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    public virtual DbSet<DetailType> DetailTypes { get; set; }

    public virtual DbSet<DriverStat> DriverStats { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<EntityAttributeValue> EntityAttributeValues { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<ExcelDataRecord> ExcelDataRecords { get; set; }

    public virtual DbSet<ExcelDataRecordAttribute> ExcelDataRecordAttributes { get; set; }

    public virtual DbSet<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; }

    public virtual DbSet<Logger> Loggers { get; set; }

    public virtual DbSet<MasterLog> MasterLogs { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<NoteAttachment> NoteAttachments { get; set; }

    public virtual DbSet<NoteComment> NoteComments { get; set; }

    public virtual DbSet<NoteTag> NoteTags { get; set; }

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

    public virtual DbSet<UserEvent> UserEvents { get; set; }

    public virtual DbSet<UserEventDetail> UserEventDetails { get; set; }

    public virtual DbSet<UserEventDetailText> UserEventDetailTexts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\\\\\\\Dev\\\\\\\\BlazorApp1\\\\\\\\BlazorApp1\\\\\\\\Data\\\\\\\\BlazorSQLite.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasIndex(e => e.TeamId, "IX_ApplicationUsers_TeamId");

            entity.HasOne(d => d.Team).WithMany(p => p.ApplicationUsers).HasForeignKey(d => d.TeamId);
        });

        modelBuilder.Entity<ApplicationUserDetail>(entity =>
        {
            entity.ToTable("ApplicationUserDetail");

            entity.HasIndex(e => e.ApplicationUserId, "IX_ApplicationUserDetail_ApplicationUserId").IsUnique();

            entity.HasIndex(e => e.DetailId, "IX_ApplicationUserDetail_DetailId");

            entity.HasIndex(e => e.DriverStatsId, "IX_ApplicationUserDetail_DriverStatsId").IsUnique();

            entity.HasOne(d => d.ApplicationUser).WithOne(p => p.ApplicationUserDetail).HasForeignKey<ApplicationUserDetail>(d => d.ApplicationUserId);

            entity.HasOne(d => d.Detail).WithMany(p => p.ApplicationUserDetails).HasForeignKey(d => d.DetailId);

            entity.HasOne(d => d.DriverStats).WithOne(p => p.ApplicationUserDetail).HasForeignKey<ApplicationUserDetail>(d => d.DriverStatsId);
        });

        modelBuilder.Entity<ApplicationUserStaticDetail>(entity =>
        {
            entity.ToTable("ApplicationUserStaticDetail");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ApplicationUserStaticDetail).HasForeignKey<ApplicationUserStaticDetail>(d => d.Id);
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasIndex(e => e.SourceId, "IX_Cars_SourceId");

            entity.HasOne(d => d.Source).WithMany(p => p.Cars).HasForeignKey(d => d.SourceId);
        });

        modelBuilder.Entity<CarDetail>(entity =>
        {
            entity.ToTable("CarDetail");

            entity.HasIndex(e => e.CarEventId, "IX_CarDetail_CarEventId");

            entity.HasIndex(e => e.CarId, "IX_CarDetail_CarId");

            entity.HasIndex(e => e.DetailId, "IX_CarDetail_DetailId");

            entity.HasOne(d => d.CarEvent).WithMany(p => p.CarDetails).HasForeignKey(d => d.CarEventId);

            entity.HasOne(d => d.Car).WithMany(p => p.CarDetails).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Detail).WithMany(p => p.CarDetails).HasForeignKey(d => d.DetailId);
        });

        modelBuilder.Entity<CarEvent>(entity =>
        {
            entity.ToTable("CarEvent");

            entity.HasIndex(e => e.CarId, "IX_CarEvent_CarId");

            entity.HasIndex(e => e.EventId, "IX_CarEvent_EventId");

            entity.HasOne(d => d.Car).WithMany(p => p.CarEvents).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Event).WithMany(p => p.CarEvents).HasForeignKey(d => d.EventId);
        });

        modelBuilder.Entity<CarEventDetail>(entity =>
        {
            entity.ToTable("CarEventDetail");

            entity.HasIndex(e => e.CarDetailId, "IX_CarEventDetail_CarDetailId");

            entity.HasIndex(e => e.CarEventId, "IX_CarEventDetail_CarEventId");

            entity.HasOne(d => d.CarDetail).WithMany(p => p.CarEventDetails).HasForeignKey(d => d.CarDetailId);

            entity.HasOne(d => d.CarEvent).WithMany(p => p.CarEventDetails).HasForeignKey(d => d.CarEventId);
        });

        modelBuilder.Entity<CarStaticDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.CarStaticDetail)
                .HasForeignKey<CarStaticDetail>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CarStatus>(entity =>
        {
            entity.ToTable("CarStatus");

            entity.HasIndex(e => e.CarId, "IX_CarStatus_CarId");

            entity.HasIndex(e => e.StatusId, "IX_CarStatus_StatusId");

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

            entity.HasIndex(e => e.Name, "IX_DetailTypes_Name");

            entity.HasOne(d => d.CarDetail).WithMany(p => p.DetailTypes).HasForeignKey(d => d.CarDetailId);
        });

        modelBuilder.Entity<EntityAttributeValue>(entity =>
        {
            entity.HasIndex(e => e.AttributeId, "IX_EntityAttributeValues_AttributeId");

            entity.HasIndex(e => e.EntityId, "IX_EntityAttributeValues_EntityId");

            entity.HasOne(d => d.Attribute).WithMany(p => p.EntityAttributeValues).HasForeignKey(d => d.AttributeId);

            entity.HasOne(d => d.Entity).WithMany(p => p.EntityAttributeValues).HasForeignKey(d => d.EntityId);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event");

            entity.HasIndex(e => e.CarId, "IX_Event_CarId");

            entity.HasIndex(e => e.CategoryId, "IX_Event_CategoryId");

            entity.HasIndex(e => e.EventTypeId, "IX_Event_EventTypeId");

            entity.HasIndex(e => e.TeamTimelineId, "IX_Event_TeamTimelineId");

            entity.HasIndex(e => e.TimelineId, "IX_Event_TimelineId");

            entity.HasIndex(e => e.UserId, "IX_Event_UserId");

            entity.HasOne(d => d.Car).WithMany(p => p.Events).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Category).WithMany(p => p.Events).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.EventType).WithMany(p => p.Events).HasForeignKey(d => d.EventTypeId);

            entity.HasOne(d => d.TeamTimeline).WithMany(p => p.Events).HasForeignKey(d => d.TeamTimelineId);

            entity.HasOne(d => d.Timeline).WithMany(p => p.Events).HasForeignKey(d => d.TimelineId);

            entity.HasOne(d => d.User).WithMany(p => p.Events).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.ToTable("EventType");

            entity.HasIndex(e => e.Name, "IX_EventType_Name").IsUnique();
        });

        modelBuilder.Entity<ExcelDataRecordAttribute>(entity =>
        {
            entity.HasIndex(e => e.ExcelDataRecordId, "IX_ExcelDataRecordAttributes_ExcelDataRecordId");

            entity.HasOne(d => d.ExcelDataRecord).WithMany(p => p.ExcelDataRecordAttributes).HasForeignKey(d => d.ExcelDataRecordId);
        });

        modelBuilder.Entity<ExcelDataRecordChange>(entity =>
        {
            entity.HasIndex(e => e.ExcelDataRecordId, "IX_ExcelDataRecordChanges_ExcelDataRecordId");

            entity.HasOne(d => d.ExcelDataRecord).WithMany(p => p.ExcelDataRecordChanges).HasForeignKey(d => d.ExcelDataRecordId);
        });

        modelBuilder.Entity<Logger>(entity =>
        {
            entity.ToTable("Logger");

            entity.HasIndex(e => e.CarId, "IX_Logger_CarId");

            entity.HasOne(d => d.Car).WithMany(p => p.Loggers).HasForeignKey(d => d.CarId);
        });

        modelBuilder.Entity<MasterLog>(entity =>
        {
            entity.ToTable("MasterLog");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasIndex(e => e.AuthorId, "IX_Notes_AuthorId");

            entity.HasOne(d => d.Author).WithMany(p => p.Notes).HasForeignKey(d => d.AuthorId);
        });

        modelBuilder.Entity<NoteAttachment>(entity =>
        {
            entity.ToTable("NoteAttachment");

            entity.HasIndex(e => e.NoteId, "IX_NoteAttachment_NoteId");

            entity.HasOne(d => d.Note).WithMany(p => p.NoteAttachments).HasForeignKey(d => d.NoteId);
        });

        modelBuilder.Entity<NoteComment>(entity =>
        {
            entity.ToTable("NoteComment");

            entity.HasIndex(e => e.AuthorId, "IX_NoteComment_AuthorId");

            entity.HasIndex(e => e.NoteId, "IX_NoteComment_NoteId");

            entity.HasOne(d => d.Author).WithMany(p => p.NoteComments).HasForeignKey(d => d.AuthorId);

            entity.HasOne(d => d.Note).WithMany(p => p.NoteComments).HasForeignKey(d => d.NoteId);
        });

        modelBuilder.Entity<NoteTag>(entity =>
        {
            entity.ToTable("NoteTag");

            entity.HasIndex(e => e.NoteId, "IX_NoteTag_NoteId");

            entity.HasOne(d => d.Note).WithMany(p => p.NoteTags).HasForeignKey(d => d.NoteId);
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.ToTable("Source");

            entity.HasIndex(e => e.Name, "IX_Source_Name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");
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
            entity.ToTable("Ticket");

            entity.HasIndex(e => e.ApplicationUserDetailId, "IX_Ticket_ApplicationUserDetailId");

            entity.HasIndex(e => e.AssigneeId, "IX_Ticket_AssigneeId");

            entity.HasIndex(e => e.CreatorId, "IX_Ticket_CreatorId");

            entity.HasOne(d => d.ApplicationUserDetail).WithMany(p => p.TicketApplicationUserDetails).HasForeignKey(d => d.ApplicationUserDetailId);

            entity.HasOne(d => d.Assignee).WithMany(p => p.TicketAssignees).HasForeignKey(d => d.AssigneeId);

            entity.HasOne(d => d.Creator).WithMany(p => p.TicketCreators).HasForeignKey(d => d.CreatorId);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.TicketIdNavigation).HasForeignKey<Ticket>(d => d.Id);
        });

        modelBuilder.Entity<TicketAttachment>(entity =>
        {
            entity.ToTable("TicketAttachment");

            entity.HasIndex(e => e.TicketId1, "IX_TicketAttachment_TicketId1");

            entity.HasOne(d => d.TicketId1Navigation).WithMany(p => p.TicketAttachments).HasForeignKey(d => d.TicketId1);
        });

        modelBuilder.Entity<TicketCategory>(entity =>
        {
            entity.ToTable("TicketCategory");
        });

        modelBuilder.Entity<TicketComment>(entity =>
        {
            entity.ToTable("TicketComment");

            entity.HasIndex(e => e.AuthorId, "IX_TicketComment_AuthorId");

            entity.HasIndex(e => e.TicketId1, "IX_TicketComment_TicketId1");

            entity.HasOne(d => d.Author).WithMany(p => p.TicketComments).HasForeignKey(d => d.AuthorId);

            entity.HasOne(d => d.TicketId1Navigation).WithMany(p => p.TicketComments).HasForeignKey(d => d.TicketId1);
        });

        modelBuilder.Entity<TicketHistory>(entity =>
        {
            entity.ToTable("TicketHistory");

            entity.HasIndex(e => e.OwnerId, "IX_TicketHistory_OwnerId");

            entity.HasIndex(e => e.TicketId1, "IX_TicketHistory_TicketId1");

            entity.HasIndex(e => e.UserDetailId1, "IX_TicketHistory_UserDetailId1");

            entity.HasOne(d => d.Owner).WithMany(p => p.TicketHistories).HasForeignKey(d => d.OwnerId);

            entity.HasOne(d => d.TicketId1Navigation).WithMany(p => p.TicketHistories).HasForeignKey(d => d.TicketId1);

            entity.HasOne(d => d.UserDetailId1Navigation).WithMany(p => p.TicketHistories).HasForeignKey(d => d.UserDetailId1);
        });

        modelBuilder.Entity<TicketTag>(entity =>
        {
            entity.ToTable("TicketTag");

            entity.HasIndex(e => e.TicketId1, "IX_TicketTag_TicketId1");

            entity.HasOne(d => d.TicketId1Navigation).WithMany(p => p.TicketTags).HasForeignKey(d => d.TicketId1);
        });

        modelBuilder.Entity<Timeline>(entity =>
        {
            entity.ToTable("Timeline");

            entity.HasIndex(e => e.ApplicationUserDetailId, "IX_Timeline_ApplicationUserDetailId");

            entity.HasOne(d => d.ApplicationUserDetail).WithMany(p => p.Timelines).HasForeignKey(d => d.ApplicationUserDetailId);
        });

        modelBuilder.Entity<UserEvent>(entity =>
        {
            entity.ToTable("UserEvent");

            entity.HasIndex(e => e.ApplicationUserDetailId, "IX_UserEvent_ApplicationUserDetailId");

            entity.HasIndex(e => e.ApplicationUserId, "IX_UserEvent_ApplicationUserId");

            entity.HasIndex(e => e.EventId, "IX_UserEvent_EventId");

            entity.HasIndex(e => e.UserId, "IX_UserEvent_UserId");

            entity.HasOne(d => d.ApplicationUserDetail).WithMany(p => p.UserEvents).HasForeignKey(d => d.ApplicationUserDetailId);

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.UserEventApplicationUsers).HasForeignKey(d => d.ApplicationUserId);

            entity.HasOne(d => d.Event).WithMany(p => p.UserEvents).HasForeignKey(d => d.EventId);

            entity.HasOne(d => d.User).WithMany(p => p.UserEventUsers).HasForeignKey(d => d.UserId);
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

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.UserEventDetailApplicationUsers).HasForeignKey(d => d.ApplicationUserId);

            entity.HasOne(d => d.Car).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.CarId);

            entity.HasOne(d => d.Detail).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.DetailId);

            entity.HasOne(d => d.Event).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.EventId);

            entity.HasOne(d => d.UserEvent).WithMany(p => p.UserEventDetails).HasForeignKey(d => d.UserEventId);

            entity.HasOne(d => d.User).WithMany(p => p.UserEventDetailUsers).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserEventDetailText>(entity =>
        {
            entity.ToTable("UserEventDetailText");

            entity.HasIndex(e => e.UserEventDetailId, "IX_UserEventDetailText_UserEventDetailId");

            entity.HasOne(d => d.UserEventDetail).WithMany(p => p.UserEventDetailTexts).HasForeignKey(d => d.UserEventDetailId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
