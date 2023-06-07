using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class RegisterMatchRequest
{
    public List<string>? PlayerTags { get; set; }
    public GameModeEnum GameMode { get; set; }
}
