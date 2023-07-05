using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace MageCorp.ClashRoyaleApi.Client.Extensions;

/// <summary>
/// 
/// </summary>
public static class ConfigurationExtensions
{

    /// <summary>
    /// Gets the ApiOptions section
    /// </summary>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static ApiOptions GetApiOptionsSection(this IConfigurationRoot configuration)
    {
        return GetApiOptionsSection(configuration, typeof(ApiOptions).Name);
    }

    /// <summary>
    /// Gets the named ApiOptions section
    /// </summary>
    /// <param name="configuration"></param>
    /// <param name="sectionName">The ApiOptions section name</param>
    /// <returns></returns>
    public static ApiOptions GetApiOptionsSection(this IConfigurationRoot configuration, string sectionName)
    {
        var apiOptions = new ApiOptions();
        new ConfigureFromConfigurationOptions<ApiOptions>(configuration.GetSection(sectionName)).Configure(apiOptions);
        return apiOptions;
    }
}
