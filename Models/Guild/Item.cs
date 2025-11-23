using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models.Guild;

public class Item
{
    [Key]
    public int ItemId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string Category { get; set; } = string.Empty;

    public string? IconUrl { get; set; }

    public bool IsTradeable { get; set; } = true;
    public bool IsStackable { get; set; } = false;

    public decimal? EstimatedValue { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual ICollection<PlayerItem> PlayerItems { get; set; } = new List<PlayerItem>();
    public virtual ICollection<QuestRequirement> QuestRequirements { get; set; } = new List<QuestRequirement>();
}
