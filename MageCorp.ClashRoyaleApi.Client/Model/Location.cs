using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Location : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? LocalizedName { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Id { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public bool IsCountry { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? CountryCode { get; internal set; }
}
