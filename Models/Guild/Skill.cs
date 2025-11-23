using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models.Guild;

public class Skill
{
    [Key]
    public int SkillId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string Category { get; set; } = string.Empty;

    public string? IconUrl { get; set; }

    public int MaxLevel { get; set; } = 99;

    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual ICollection<PlayerSkill> PlayerSkills { get; set; } = new List<PlayerSkill>();
}
