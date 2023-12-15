namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

/// <summary>
/// </summary>
public abstract class ApiPagedResponse<T> : ApiResponse
{
    /// <summary>
    /// </summary>
    public List<T>? Items { get; internal set; }
    /// <summary>
    /// </summary>
    public Paging? Paging { get; internal set; }

}
