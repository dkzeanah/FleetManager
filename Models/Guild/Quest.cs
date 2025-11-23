using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models.Guild;

public class Quest
{
    [Key]
    public int QuestId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(2000)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string Category { get; set; } = string.Empty;

    public int DifficultyLevel { get; set; } = 1;

    public int? RequiredLevel { get; set; }

    public int EstimatedDurationMinutes { get; set; }

    public int RewardExperience { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public virtual ICollection<PlayerQuest> PlayerQuests { get; set; } = new List<PlayerQuest>();
    public virtual ICollection<QuestRequirement> QuestRequirements { get; set; } = new List<QuestRequirement>();
    public virtual ICollection<QuestStep> QuestSteps { get; set; } = new List<QuestStep>();
}
