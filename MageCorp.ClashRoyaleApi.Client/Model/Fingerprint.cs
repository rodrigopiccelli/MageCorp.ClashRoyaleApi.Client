using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Fingerprint: ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Sha { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Version { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<FileInfo>? Files { get; internal set; }
}
