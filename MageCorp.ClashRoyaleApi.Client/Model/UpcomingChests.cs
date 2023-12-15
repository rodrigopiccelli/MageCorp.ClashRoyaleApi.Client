using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class UpcomingChests : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public ChestList? Items { get; internal set; }
}
