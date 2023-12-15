using MageCorp.ClashRoyaleApi.Client.Converter;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LadderTournament
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public GameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int TournamentLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public SurvivalMilestoneRewardList? MilestoneRewards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public SurvivalMilestoneRewardList? FreeTierRewards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxLosses { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MinExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Title { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public SurvivalMilestoneRewardList? TopRankReward { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int MaxTopRewardRank { get; internal set; }
}
