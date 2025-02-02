using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Card
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Id { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxEvolutionLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ElixirCost { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public IconUrls? IconUrls { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Rarity? Rarity { get; internal set; }
}
