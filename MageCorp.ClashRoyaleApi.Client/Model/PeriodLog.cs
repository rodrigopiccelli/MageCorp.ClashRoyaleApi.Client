using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PeriodLog
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PeriodLogEntryList? Items { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int PeriodIndex { get; internal set; }
}
