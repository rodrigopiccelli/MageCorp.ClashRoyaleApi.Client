using MageCorp.ClashRoyaleApi.Client.Model.Abstract;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class UpcomingChests : ApiResponse
{
    public ChestList? Items { get; set; }
}
