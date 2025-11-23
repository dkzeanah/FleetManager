using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public class QuestStep
{
    [Key]
    public int QuestStepId { get; set; }

    [ForeignKey(nameof(Quest))]
    public int QuestId { get; set; }

    public int StepNumber { get; set; }

    [Required]
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string? Objective { get; set; }

    public bool RequiresItem { get; set; } = false;

    public int? RequiredItemId { get; set; }

    // Navigation property
    public virtual Quest Quest { get; set; } = null!;
}
