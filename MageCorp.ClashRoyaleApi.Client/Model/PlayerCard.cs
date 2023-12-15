namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerCard : Card
{
    /// <summary>
    /// </summary>
    public int Level { get; internal set; }
    /// <summary>
    /// </summary>
    public int StarLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int EvolutionLevel { get; internal set; }
    /// <summary>
    /// </summary>
    public int Count { get; internal set; }
}
