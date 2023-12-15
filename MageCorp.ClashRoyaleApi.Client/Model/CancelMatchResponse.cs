using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CancelMatchResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public bool Success { get; internal set; }
}
