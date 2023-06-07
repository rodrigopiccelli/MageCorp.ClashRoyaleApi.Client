using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class LadderTournament
{
    public GameMode? GameMode { get; set; }
    public int TournamentLevel { get; set; }
    public SurvivalMilestoneRewardList? MilestoneRewards { get; set; }
    public SurvivalMilestoneRewardList? FreeTierRewards { get; set; }
    public int MaxLosses { get; set; }
    public int MinExpLevel { get; set; }
    public string? Tag { get; set; }
    public string? Title { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? StartTime { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? EndTime { get; set; }
    public SurvivalMilestoneRewardList? TopRankReward { get; set; }
}
