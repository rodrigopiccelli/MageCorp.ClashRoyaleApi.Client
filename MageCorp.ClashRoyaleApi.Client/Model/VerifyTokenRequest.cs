using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class VerifyTokenRequest
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Token { get; internal set; }
}
