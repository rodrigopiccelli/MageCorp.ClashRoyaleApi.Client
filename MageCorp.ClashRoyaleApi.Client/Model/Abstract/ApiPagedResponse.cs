namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

public abstract class ApiPagedResponse<T> : ApiResponse
{
    public List<T>? Items { get; set; }
    public Paging? Paging { get; set; }

}
