using MageCorp.ClashRoyaleApi.Client.Model.Abstract;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class UpcomingChests : ApiResponse
{
    /// <summary>
    /// </summary>
    public ChestList? Items { get; set; }
}
