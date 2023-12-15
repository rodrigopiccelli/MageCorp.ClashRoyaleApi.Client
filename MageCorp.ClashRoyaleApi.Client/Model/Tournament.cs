using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Tournament : ApiResponse
{
    /// <summary>
    /// </summary>
    public TournamentMemberList? MembersList { get; internal set; }
    /// <summary>
    /// </summary>
    public TournamentStateEnum Status { get; internal set; }
    /// <summary>
    /// </summary>
    public int PreparationDuration { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartedTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndedTime { get; internal set; }
    /// <summary>
    /// </summary>
    public int FirstPlaceCardPrize { get; internal set; }
    /// <summary>
    /// </summary>
    public GameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    public int Duration { get; internal set; }
    /// <summary>
    /// </summary>
    public TournamentTypeEnum Type { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? CreatorTag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Description { get; internal set; }
    /// <summary>
    /// </summary>
    public int Capacity { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxCapacity { get; internal set; }
    /// <summary>
    /// </summary>
    public int LevelCap { get; internal set; }
}
