using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Card
{
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public int Id { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxEvolutionLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int ElixirCost { get; internal set; }
    /// <summary>
    /// </summary>
    public IconUrls? IconUrls { get; internal set; }
    /// <summary>
    /// </summary>
    public RarityEnum Rarity { get; internal set; }
}
