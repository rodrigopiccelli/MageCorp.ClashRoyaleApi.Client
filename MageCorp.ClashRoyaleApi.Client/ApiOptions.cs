namespace MageCorp.ClashRoyaleApi.Client;

public class ApiOptions
{
    public ApiOptions() : this(string.Empty) { }

    /// <param name="bearerToken"></param>
    /// <param name="apiAddress">https://api.clashroyale.com</param>
    /// <param name="apiVersion">v1</param>
    /// <param name="useProxy">false</param>
    /// <param name="proxyAddress">https://proxy.royaleapi.dev</param>
    public ApiOptions(string bearerToken, string apiAddress = "https://api.clashroyale.com", string apiVersion = "v1", bool useProxy = false, string proxyAddress = "https://proxy.royaleapi.dev")
    {
        BearerToken = bearerToken;
        ApiAddress = apiAddress;
        ApiVersion = apiVersion;
        UseProxy = useProxy;
        ProxyAddress = proxyAddress;
    }

    public string BearerToken { get; set; }
    public string ApiAddress { get; set; }
    public string ProxyAddress { get; set; }
    public string ApiVersion { get; set; }
    public bool UseProxy { get; set; }
}
