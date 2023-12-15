namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PeriodLogEntry
{
    /// <summary>
    /// </summary>
    public PeriodLogEntryClan? Clan { get; internal set; }
    /// <summary>
    /// </summary>
    public int PointsEarned { get; internal set; }
    /// <summary>
    /// </summary>
    public int ProgressStartOfDay { get; internal set; }
    /// <summary>
    /// </summary>
    public int ProgressEndOfDay { get; internal set; }
    /// <summary>
    /// </summary>
    public int EndOfDayRank { get; internal set; }
    /// <summary>
    /// </summary>
    public int ProgressEarned { get; internal set; }
    /// <summary>
    /// </summary>
    public int NumOfDefensesRemaining { get; internal set; }
    /// <summary>
    /// </summary>
    public int ProgressEarnedFromDefenses { get; internal set; }
}
