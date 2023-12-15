using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClientError : IApiResponseError
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Reason { get ; set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Message { get; set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Type { get; set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public object? Detail { get; set; }
}
