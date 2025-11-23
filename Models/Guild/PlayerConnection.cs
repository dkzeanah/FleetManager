using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public enum ConnectionType
{
    SameSkill,
    SameItem,
    SameQuest,
    SameLocation,
    Manual
}

public class PlayerConnection
{
    [Key]
    public int ConnectionId { get; set; }

    [ForeignKey(nameof(InitiatingPlayer))]
    public int InitiatingPlayerId { get; set; }

    [ForeignKey(nameof(ConnectedPlayer))]
    public int ConnectedPlayerId { get; set; }

    public ConnectionType ConnectionType { get; set; }

    [MaxLength(500)]
    public string? ConnectionReason { get; set; }

    public int StrengthScore { get; set; } = 1;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;

    // Navigation properties
    [ForeignKey(nameof(InitiatingPlayerId))]
    public virtual Player InitiatingPlayer { get; set; } = null!;

    [ForeignKey(nameof(ConnectedPlayerId))]
    public virtual Player ConnectedPlayer { get; set; } = null!;
}
