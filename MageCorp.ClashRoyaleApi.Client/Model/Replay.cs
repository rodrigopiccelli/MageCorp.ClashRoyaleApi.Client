using MageCorp.ClashRoyaleApi.Client.Converter;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Replay
{
    public string? ReplayInfo { get; set; }
    public object? ReplayData { get; set; }
    public Version? Version { get; set; }
    public string? Tag { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? BattleTime { get; set; }
    public int ViewCount { get; set; }
    public int ShareCount { get; set; }
}
