using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public enum QuestStatus
{
    NotStarted,
    InProgress,
    Completed,
    Abandoned
}

public class PlayerQuest
{
    [Key]
    public int PlayerQuestId { get; set; }

    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }

    [ForeignKey(nameof(Quest))]
    public int QuestId { get; set; }

    public QuestStatus Status { get; set; } = QuestStatus.NotStarted;

    public int CurrentStep { get; set; } = 0;

    public DateTime? StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }

    [MaxLength(1000)]
    public string? Notes { get; set; }

    // Navigation properties
    public virtual Player Player { get; set; } = null!;
    public virtual Quest Quest { get; set; } = null!;
}
