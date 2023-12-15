using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LadderTournament
{
    /// <summary>
    /// </summary>
    public GameMode? GameMode { get; internal set; }
    /// <summary>
    /// </summary>
    public int TournamentLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? MilestoneRewards { get; internal set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? FreeTierRewards { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxLosses { get; internal set; }
    /// <summary>
    /// </summary>
    public int MinExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Title { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; internal set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? TopRankReward { get; internal set; }
    /// <summary>
    /// </summary>
    public int MaxTopRewardRank { get; internal set; }
}
