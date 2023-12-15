using MageCorp.ClashRoyaleApi.Client.Model.Abstract;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Location : ApiResponse
{
    /// <summary>
    /// </summary>
    public string? LocalizedName { get; internal set; }
    /// <summary>
    /// </summary>
    public int Id { get; internal set; }
    /// <summary>
    /// </summary>
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    public bool IsCountry { get; internal set; }
    /// <summary>
    /// </summary>
    public string? CountryCode { get; internal set; }
}
