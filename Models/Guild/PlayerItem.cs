using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models.Guild;

public class PlayerItem
{
    [Key]
    public int PlayerItemId { get; set; }

    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }

    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }

    public int Quantity { get; set; } = 1;

    public DateTime AcquiredAt { get; set; } = DateTime.UtcNow;

    public bool IsEquipped { get; set; } = false;

    [MaxLength(500)]
    public string? Notes { get; set; }

    // Navigation properties
    public virtual Player Player { get; set; } = null!;
    public virtual Item Item { get; set; } = null!;
}
