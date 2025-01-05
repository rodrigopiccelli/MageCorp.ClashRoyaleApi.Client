using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class FileInfo
{
    /// <summary>
    /// </summary>
    [JsonInclude] 
    public string? File { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude] 
    public string? Sha { get; internal set; }
}
