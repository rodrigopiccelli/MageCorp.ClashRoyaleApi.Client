using MageCorp.ClashRoyaleApi.Client.Interfaces;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class ClientError : IApiResponseError
{
    /// <summary>
    /// </summary>
    public string? Reason { get ; set; }
    /// <summary>
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// </summary>
    public object? Detail { get; set; }
}
