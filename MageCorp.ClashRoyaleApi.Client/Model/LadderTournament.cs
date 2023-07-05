using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LadderTournament
{
    /// <summary>
    /// </summary>
    public GameMode? GameMode { get; set; }
    /// <summary>
    /// </summary>
    public int TournamentLevel { get; set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? MilestoneRewards { get; set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? FreeTierRewards { get; set; }
    /// <summary>
    /// </summary>
    public int MaxLosses { get; set; }
    /// <summary>
    /// </summary>
    public int MinExpLevel { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? Title { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; set; }
    /// <summary>
    /// </summary>
    public SurvivalMilestoneRewardList? TopRankReward { get; set; }
}
