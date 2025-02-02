using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Tournament : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public TournamentMemberList? MembersList { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public TournamentState Status { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PreparationDuration { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartedTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndedTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int FirstPlaceCardPrize { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public GameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Duration { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public TournamentType Type { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? CreatorTag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Description { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Capacity { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxCapacity { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int LevelCap { get; internal set; }
}
