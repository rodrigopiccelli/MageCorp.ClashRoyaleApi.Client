using MageCorp.ClashRoyaleApi.Client.Model;
using System.Net;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

public interface IApiResponse
{
    HttpStatusCode HttpStatusCode { get; set; }
    IApiResponseError? Error { get; set; }
}
