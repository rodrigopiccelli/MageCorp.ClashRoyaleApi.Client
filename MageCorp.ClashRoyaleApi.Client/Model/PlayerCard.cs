namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerCard : Card
{
    public int Count { get; set; }
    public int Level { get; set; }
    public int StarLevel { get; set; }
    public bool Used { get; set; }
}
