using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RegisterMatchRequest
{
    /// <summary>
    /// </summary>
    public List<string>? PlayerTags { get; set; }
    /// <summary>
    /// </summary>
    public GameModeEnum GameMode { get; set; }
}
