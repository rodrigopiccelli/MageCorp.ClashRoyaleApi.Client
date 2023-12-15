using MageCorp.ClashRoyaleApi.Client.Model.Enum;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class RegisterMatchRequest
{
    /// <summary>
    /// </summary>
    public List<string>? PlayerTags { get; internal set; }
    /// <summary>
    /// </summary>
    public GameModeEnum GameMode { get; internal set; }
}
