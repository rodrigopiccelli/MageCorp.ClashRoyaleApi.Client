using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RegisterMatchRequest
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<string>? PlayerTags { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Enum.GameMode GameMode { get; internal set; }
}
