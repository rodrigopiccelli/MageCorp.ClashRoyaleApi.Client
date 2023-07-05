using System.Net;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// </summary>
public interface IApiResponse
{
    /// <summary>
    /// </summary>
    HttpStatusCode HttpStatusCode { get; set; }
    /// <summary>
    /// </summary>
    IApiResponseError? Error { get; set; }
}
