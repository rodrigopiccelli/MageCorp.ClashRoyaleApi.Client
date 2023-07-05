namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// </summary>
public interface IApiResponseError
{
    /// <summary>
    /// </summary>
    public string? Reason { get; set; }
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
