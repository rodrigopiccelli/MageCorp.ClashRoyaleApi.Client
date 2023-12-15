using MageCorp.ClashRoyaleApi.Client.Converter;
using MageCorp.ClashRoyaleApi.Client.Model.Enum;
using Newtonsoft.Json;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClanMember
{
    /// <summary>
    /// </summary>
    public Arena? Arena { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanChestPoints { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(ClashRoyaleApiDateFormatJsonConverter))]
    public DateTime? LastSeen { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public RoleEnum Role { get; internal set; }
    /// <summary>
    /// </summary>
    public int ExpLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int Trophies { get; internal set; }
    /// <summary>
    /// </summary>
    public int ClanRank { get; internal set; }
    /// <summary>
    /// </summary>
    public int PreviousClanRank { get; internal set; }
    /// <summary>
    /// </summary>
    public int Donations { get; internal set; }
    /// <summary>
    /// </summary>
    public int DonationsReceived { get; internal set; }
}
