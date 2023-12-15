using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerBattleRound
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public PlayerCardList? Cards { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public float ElixirLeaked { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int Crowns { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int KingTowerHitPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<int>? PrincessTowersHitPoints { get; internal set; }
}
