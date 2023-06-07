using MageCorp.ClashRoyaleApi.Client.Model.Abstract;

namespace MageCorp.ClashRoyaleApi.Client.Model;

public class Location : ApiResponse
{
    public string? LocalizedName { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsCountry { get; set; }
    public string? CountryCode { get; set; }
}
