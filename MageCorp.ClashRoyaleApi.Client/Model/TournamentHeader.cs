using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class TournamentHeader
{
    public TournamentStateEnum State { get; set; }
    public int PreparationDuration { get; set; }
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedTime { get; set; }
    public int FirstPlaceCardPrize { get; set; }
    public GameMode? GameMode { get; set; }
    public int Duration { get; set; }
    public TournamentTypeEnum Type { get; set; }
    public string? Tag { get; set; }
    public string? CreatorTag { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Capacity { get; set; }
    public int MaxCapacity { get; set; }
    public int LevelCap { get; set; }
}
