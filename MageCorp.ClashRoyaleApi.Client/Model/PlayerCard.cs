using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerCard : Card
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Level { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int StarLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int EvolutionLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Count { get; internal set; }
}
