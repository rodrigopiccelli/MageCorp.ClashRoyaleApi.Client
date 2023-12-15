using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PeriodLogEntry
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PeriodLogEntryClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PointsEarned { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ProgressStartOfDay { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ProgressEndOfDay { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int EndOfDayRank { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ProgressEarned { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int NumOfDefensesRemaining { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int ProgressEarnedFromDefenses { get; internal set; }
}
