using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public class PlayerSkill
{
    [Key]
    public int PlayerSkillId { get; set; }

    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }

    [ForeignKey(nameof(Skill))]
    public int SkillId { get; set; }

    public int Level { get; set; } = 1;

    public long Experience { get; set; } = 0;

    public DateTime AcquiredAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastUpdated { get; set; }

    // Navigation properties
    public virtual Player Player { get; set; } = null!;
    public virtual Skill Skill { get; set; } = null!;
}
