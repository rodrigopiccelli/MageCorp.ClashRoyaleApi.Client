using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

/// <summary>
/// </summary>
public abstract class ApiPagedResponse<T> : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<T>? Items { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Paging? Paging { get; internal set; }

}
