using BlazorApp1.Models.Guild;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public class GuildDbContext : DbContext
{
    public GuildDbContext(DbContextOptions<GuildDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<PlayerSkill> PlayerSkills { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<PlayerItem> PlayerItems { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<PlayerQuest> PlayerQuests { get; set; }
    public DbSet<QuestStep> QuestSteps { get; set; }
    public DbSet<QuestRequirement> QuestRequirements { get; set; }
    public DbSet<GuildEntity> Guilds { get; set; }
    public DbSet<GuildMember> GuildMembers { get; set; }
    public DbSet<PlayerConnection> PlayerConnections { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Player
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
            entity.HasIndex(e => e.Username).IsUnique();
            entity.HasIndex(e => new { e.Latitude, e.Longitude });
        });

        // Configure PlayerSkill
        modelBuilder.Entity<PlayerSkill>(entity =>
        {
            entity.HasIndex(e => new { e.PlayerId, e.SkillId }).IsUnique();

            entity.HasOne(ps => ps.Player)
                .WithMany(p => p.PlayerSkills)
                .HasForeignKey(ps => ps.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(ps => ps.Skill)
                .WithMany(s => s.PlayerSkills)
                .HasForeignKey(ps => ps.SkillId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure PlayerItem
        modelBuilder.Entity<PlayerItem>(entity =>
        {
            entity.HasIndex(e => new { e.PlayerId, e.ItemId });

            entity.HasOne(pi => pi.Player)
                .WithMany(p => p.PlayerItems)
                .HasForeignKey(pi => pi.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(pi => pi.Item)
                .WithMany(i => i.PlayerItems)
                .HasForeignKey(pi => pi.ItemId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure PlayerQuest
        modelBuilder.Entity<PlayerQuest>(entity =>
        {
            entity.HasIndex(e => new { e.PlayerId, e.QuestId });
            entity.HasIndex(e => e.Status);

            entity.HasOne(pq => pq.Player)
                .WithMany(p => p.PlayerQuests)
                .HasForeignKey(pq => pq.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(pq => pq.Quest)
                .WithMany(q => q.PlayerQuests)
                .HasForeignKey(pq => pq.QuestId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure QuestStep
        modelBuilder.Entity<QuestStep>(entity =>
        {
            entity.HasIndex(e => new { e.QuestId, e.StepNumber }).IsUnique();

            entity.HasOne(qs => qs.Quest)
                .WithMany(q => q.QuestSteps)
                .HasForeignKey(qs => qs.QuestId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure QuestRequirement
        modelBuilder.Entity<QuestRequirement>(entity =>
        {
            entity.HasOne(qr => qr.Quest)
                .WithMany(q => q.QuestRequirements)
                .HasForeignKey(qr => qr.QuestId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(qr => qr.Item)
                .WithMany(i => i.QuestRequirements)
                .HasForeignKey(qr => qr.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(qr => qr.Skill)
                .WithMany()
                .HasForeignKey(qr => qr.SkillId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Configure GuildMember
        modelBuilder.Entity<GuildMember>(entity =>
        {
            entity.HasIndex(e => new { e.GuildId, e.PlayerId }).IsUnique();

            entity.HasOne(gm => gm.GuildEntity)
                .WithMany(g => g.GuildMembers)
                .HasForeignKey(gm => gm.GuildId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(gm => gm.Player)
                .WithMany(p => p.GuildMemberships)
                .HasForeignKey(gm => gm.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure PlayerConnection
        modelBuilder.Entity<PlayerConnection>(entity =>
        {
            entity.HasIndex(e => new { e.InitiatingPlayerId, e.ConnectedPlayerId });
            entity.HasIndex(e => e.ConnectionType);

            entity.HasOne(pc => pc.InitiatingPlayer)
                .WithMany(p => p.InitiatedConnections)
                .HasForeignKey(pc => pc.InitiatingPlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(pc => pc.ConnectedPlayer)
                .WithMany(p => p.ReceivedConnections)
                .HasForeignKey(pc => pc.ConnectedPlayerId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Seed data
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        // Seed Skills
        modelBuilder.Entity<Skill>().HasData(
            new Skill { SkillId = 1, Name = "Programming", Description = "Software development and coding", Category = "Technology", MaxLevel = 99 },
            new Skill { SkillId = 2, Name = "Sewing", Description = "Textile crafting and tailoring", Category = "Crafting", MaxLevel = 99 },
            new Skill { SkillId = 3, Name = "Cooking", Description = "Culinary arts and food preparation", Category = "Cooking", MaxLevel = 99 },
            new Skill { SkillId = 4, Name = "Woodworking", Description = "Carpentry and wood crafting", Category = "Crafting", MaxLevel = 99 },
            new Skill { SkillId = 5, Name = "Gardening", Description = "Plant cultivation and landscaping", Category = "Farming", MaxLevel = 99 },
            new Skill { SkillId = 6, Name = "Photography", Description = "Photo and video capture", Category = "Art", MaxLevel = 99 },
            new Skill { SkillId = 7, Name = "Music", Description = "Playing musical instruments", Category = "Art", MaxLevel = 99 },
            new Skill { SkillId = 8, Name = "Fitness", Description = "Physical training and exercise", Category = "Combat", MaxLevel = 99 }
        );

        // Seed Items
        modelBuilder.Entity<Item>().HasData(
            new Item { ItemId = 1, Name = "Sewing Machine", Description = "A standard household sewing machine", Category = "Tools", IsTradeable = true, EstimatedValue = 200 },
            new Item { ItemId = 2, Name = "Laptop", Description = "A programmable computer", Category = "Electronics", IsTradeable = true, EstimatedValue = 1000 },
            new Item { ItemId = 3, Name = "Camera", Description = "Digital camera for photography", Category = "Electronics", IsTradeable = true, EstimatedValue = 500 },
            new Item { ItemId = 4, Name = "Guitar", Description = "Acoustic guitar", Category = "Instruments", IsTradeable = true, EstimatedValue = 300 },
            new Item { ItemId = 5, Name = "Gardening Tools Set", Description = "Complete set of gardening tools", Category = "Tools", IsTradeable = true, EstimatedValue = 100 }
        );

        // Seed Quests
        modelBuilder.Entity<Quest>().HasData(
            new Quest
            {
                QuestId = 1,
                Name = "The Programmer's Journey",
                Description = "Learn to code and build your first application",
                Category = "Technology",
                DifficultyLevel = 2,
                EstimatedDurationMinutes = 240,
                RewardExperience = 1000
            },
            new Quest
            {
                QuestId = 2,
                Name = "Master Tailor",
                Description = "Create your first custom garment",
                Category = "Crafting",
                DifficultyLevel = 1,
                EstimatedDurationMinutes = 120,
                RewardExperience = 500
            }
        );
    }
}
