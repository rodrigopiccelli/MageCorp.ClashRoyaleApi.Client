using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

/// <summary>
/// </summary>
public abstract class ApiItemizedResponse<T> : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<T>? Items { get; internal set; }
}
