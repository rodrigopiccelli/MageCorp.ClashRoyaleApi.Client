using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Version
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Build { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Major { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Content { get; internal set; }
}
