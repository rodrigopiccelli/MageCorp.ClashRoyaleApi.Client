using MageCorp.ClashRoyaleApi.Client.Model.Abstract;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Location : ApiResponse
{
    /// <summary>
    /// </summary>
    public string? LocalizedName { get; set; }
    /// <summary>
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// </summary>
    public bool IsCountry { get; set; }
    /// <summary>
    /// </summary>
    public string? CountryCode { get; set; }
}
