using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace MageCorp.ClashRoyaleApi.Client.Extensions;

public static class ConfigurationExtensions
{

    public static ApiOptions GetApiOptionsSection(this IConfigurationRoot configuration)
    {
        return GetApiOptionsSection(configuration, typeof(ApiOptions).Name);
    }

    public static ApiOptions GetApiOptionsSection(this IConfigurationRoot configuration, string sectionName)
    {
        var apiOptions = new ApiOptions();
        new ConfigureFromConfigurationOptions<ApiOptions>(configuration.GetSection(sectionName)).Configure(apiOptions);
        return apiOptions;
    }
}
