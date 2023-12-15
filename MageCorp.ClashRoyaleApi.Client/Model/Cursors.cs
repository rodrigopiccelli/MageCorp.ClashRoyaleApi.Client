using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Cursors
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? After { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Before { get; internal set; }
}
