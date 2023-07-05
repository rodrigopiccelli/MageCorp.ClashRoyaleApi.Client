namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PeriodLogEntry
{
    /// <summary>
    /// </summary>
    public PeriodLogEntryClan? Clan { get; set; }
    /// <summary>
    /// </summary>
    public int PointsEarned { get; set; }
    /// <summary>
    /// </summary>
    public int ProgressStartOfDay { get; set; }
    /// <summary>
    /// </summary>
    public int ProgressEndOfDay { get; set; }
    /// <summary>
    /// </summary>
    public int EndOfDayRank { get; set; }
    /// <summary>
    /// </summary>
    public int ProgressEarned { get; set; }
    /// <summary>
    /// </summary>
    public int NumOfDefensesRemaining { get; set; }
    /// <summary>
    /// </summary>
    public int ProgressEarnedFromDefenses { get; set; }
}
