using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ProgressType
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BestTrophies { get; internal set; }
}
