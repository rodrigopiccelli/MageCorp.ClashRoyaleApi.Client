namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

public interface IApiResponseError
{
    public string? Reason { get; set; }
    public string? Message { get; set; }
    public string? Type { get; set; }
    public object? Detail { get; set; }
}
