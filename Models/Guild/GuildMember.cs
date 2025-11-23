using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public enum GuildRole
{
    Member,
    Officer,
    Leader
}

public class GuildMember
{
    [Key]
    public int GuildMemberId { get; set; }

    [ForeignKey(nameof(GuildEntity))]
    public int GuildId { get; set; }

    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }

    public GuildRole Role { get; set; } = GuildRole.Member;

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual GuildEntity GuildEntity { get; set; } = null!;
    public virtual Player Player { get; set; } = null!;
}
