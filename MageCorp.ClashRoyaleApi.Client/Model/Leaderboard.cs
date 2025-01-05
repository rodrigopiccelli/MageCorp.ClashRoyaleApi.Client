using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Leaderboard 
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public long Id { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
}
