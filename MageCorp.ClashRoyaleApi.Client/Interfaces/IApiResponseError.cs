namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// </summary>
public interface IApiResponseError
{
    /// <summary>
    /// </summary>
    string? Reason { get; set; }
    /// <summary>
    /// </summary>
    string? Message { get; set; }
    /// <summary>
    /// </summary>
    string? Type { get; set; }
    /// <summary>
    /// </summary>
    object? Detail { get; set; }
}
