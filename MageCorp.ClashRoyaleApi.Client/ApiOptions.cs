namespace MageCorp.ClashRoyaleApi.Client;

/// <summary>
/// Specifies the Clash Royale API options
/// </summary>
public class ApiOptions
{
    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// Clash Royale API Key generated on https://developer.clashroyale.com/
    /// </summary>
    public string BearerToken { get; set; }
    /// <summary>
    /// Clash Royale API address.
    /// https://api.clashroyale.com/
    /// </summary>
    public string ApiAddress { get; set; }
    /// <summary>
    /// Clash Royale API proxy Address.
    /// ex: https://proxy.royaleapi.dev
    /// </summary>
    public string ProxyAddress { get; set; }
    /// <summary>
    /// Clash Royale API Version.
    /// </summary>
    public string ApiVersion { get; set; }
    /// <summary>
    /// Specifies if should use proxy address.
    /// </summary>
    public bool UseProxy { get; set; }
}
