namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerCard : Card
{
    /// <summary>
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// </summary>
    public int Level { get; set; }
    /// <summary>
    /// </summary>
    public int StarLevel { get; set; }
    /// <summary>
    /// </summary>
    public bool Used { get; set; }
    /// <summary>
    /// </summary>
    public int EvolutionLevel { get; set; }
    /// <summary>
    /// </summary>
    public int MaxEvolutionLevel { get; set; }
}
