using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class TournamentHeader
{
    /// <summary>
    /// </summary>
    public TournamentStateEnum State { get; set; }
    /// <summary>
    /// </summary>
    public int PreparationDuration { get; set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? CreatedTime { get; set; }
    /// <summary>
    /// </summary>
    public int FirstPlaceCardPrize { get; set; }
    /// <summary>
    /// </summary>
    public GameMode? GameMode { get; set; }
    /// <summary>
    /// </summary>
    public int Duration { get; set; }
    /// <summary>
    /// </summary>
    public TournamentTypeEnum Type { get; set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// </summary>
    public string? CreatorTag { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// </summary>
    public int Capacity { get; set; }
    /// <summary>
    /// </summary>
    public int MaxCapacity { get; set; }
    /// <summary>
    /// </summary>
    public int LevelCap { get; set; }
}
