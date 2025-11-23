using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public class QuestRequirement
{
    [Key]
    public int QuestRequirementId { get; set; }

    [ForeignKey(nameof(Quest))]
    public int QuestId { get; set; }

    [ForeignKey(nameof(Item))]
    public int? ItemId { get; set; }

    [ForeignKey(nameof(Skill))]
    public int? SkillId { get; set; }

    public int? RequiredSkillLevel { get; set; }

    public int? RequiredItemQuantity { get; set; }

    // Navigation properties
    public virtual Quest Quest { get; set; } = null!;
    public virtual Item? Item { get; set; }
    public virtual Skill? Skill { get; set; }
}
