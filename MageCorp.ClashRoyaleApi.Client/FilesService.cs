using MageCorp.ClashRoyaleApi.Client.Abstract;
using MageCorp.ClashRoyaleApi.Client.Interfaces;
using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client;
internal class FilesService : ApiClient, IFilesService
{
    internal FilesService(HttpClient httpClient) : base(httpClient) { }

    public FilesService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

    public async Task<Fingerprint> GetFingerprintAsync() =>
        await GetAsync<Fingerprint>($"files/fingerprint");

}
