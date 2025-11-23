using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public class Player
{
    [Key]
    public int PlayerId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Bio { get; set; }

    [MaxLength(200)]
    public string? Location { get; set; }

    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastActive { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual ICollection<PlayerSkill> PlayerSkills { get; set; } = new List<PlayerSkill>();
    public virtual ICollection<PlayerItem> PlayerItems { get; set; } = new List<PlayerItem>();
    public virtual ICollection<PlayerQuest> PlayerQuests { get; set; } = new List<PlayerQuest>();
    public virtual ICollection<GuildMember> GuildMemberships { get; set; } = new List<GuildMember>();
    public virtual ICollection<PlayerConnection> InitiatedConnections { get; set; } = new List<PlayerConnection>();
    public virtual ICollection<PlayerConnection> ReceivedConnections { get; set; } = new List<PlayerConnection>();
}
