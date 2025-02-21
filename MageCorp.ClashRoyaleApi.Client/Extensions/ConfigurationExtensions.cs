using Microsoft.Extensions.Configuration;

namespace MageCorp.ClashRoyaleApi.Client.Extensions;

/// <summary>
/// Provides extension methods for retrieving ClashRoyaleApiOptions from the configuration.
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Gets the ClashRoyaleApiOptions section
    /// </summary>
    /// <param name="configuration">The configuration instance.</param>
    /// <returns>The ClashRoyaleApiOptions section.</returns>
    public static ClashRoyaleApiOptions? GetClashRoyaleApiOptionsSection(this IConfiguration configuration)
        => GetClashRoyaleApiOptionsSection(configuration, nameof(ClashRoyaleApiOptions));

    /// <summary>
    /// Gets the named ClashRoyaleApiOptions section
    /// </summary>
    /// <param name="configuration">The configuration instance.</param>
    /// <param name="sectionName">The ClashRoyaleApiOptions section name.</param>
    /// <returns>The named ClashRoyaleApiOptions section.</returns>
    public static ClashRoyaleApiOptions? GetClashRoyaleApiOptionsSection(this IConfiguration configuration, string sectionName)
        => configuration.GetSection(sectionName).Get<ClashRoyaleApiOptions>();
}
