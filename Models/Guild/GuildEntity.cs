using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models.Guild;

public class GuildEntity
{
    [Key]
    public int GuildId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(1000)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string GuildType { get; set; } = string.Empty;

    public bool IsPublic { get; set; } = true;

    public int MaxMembers { get; set; } = 100;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;

    [MaxLength(500)]
    public string? AutoJoinCriteria { get; set; }

    // Navigation properties
    public virtual ICollection<GuildMember> GuildMembers { get; set; } = new List<GuildMember>();
}
