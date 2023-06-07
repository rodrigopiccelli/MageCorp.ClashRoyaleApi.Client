using MageCorp.ClashRoyaleApi.Client.Interfaces;
using System.Net;

namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

public abstract class ApiResponse : IApiResponse
{
    public HttpStatusCode HttpStatusCode { get; set; }
    public IApiResponseError? Error { get; set; }
}
