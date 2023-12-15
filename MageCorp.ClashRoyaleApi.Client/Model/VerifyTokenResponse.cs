using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class VerifyTokenResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Token { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Status { get; internal set; }
}
