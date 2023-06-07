namespace MageCorp.ClashRoyaleApi.Client.Model;

public class PlayerAchievementProgress
{
    public int Stars { get; set; }
    public int Value { get; set; }
    public string? Name { get; set; }
    public int Target { get; set; }
    public object? Info { get; set; }
    public object? CompletionInfo { get; set; }
}
