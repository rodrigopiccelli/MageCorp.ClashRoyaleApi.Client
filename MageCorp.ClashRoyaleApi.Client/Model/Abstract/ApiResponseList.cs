using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Net;

namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

/// <summary>
/// </summary>
public abstract class ApiResponseList<T> : List<T>, IApiResponse
{
    /// <summary>
    /// </summary>
    public HttpStatusCode HttpStatusCode { get; set; }
    /// <summary>
    /// </summary>
    public IApiResponseError? Error { get; set; }
}
