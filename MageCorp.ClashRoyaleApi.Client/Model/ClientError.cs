using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class ClientError : IApiResponseError
{
    public string? Reason { get ; set; }
    public string? Message { get; set; }
    public string? Type { get; set; }
    public object? Detail { get; set; }
}
