using MageCorp.ClashRoyaleApi.Client.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MageCorp.ClashRoyaleApi.Client.Extensions;

/// <summary>
/// Extension methods for setting up ClashRoyaleApiClient services in an <see cref="IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds ClashRoyaleApiClient to the service collection using an API key.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="apiKey">The Clash Royale API key.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, string apiKey) => 
        services.AddClashRoyaleApiClient(new ApiOptions(apiKey));

    /// <summary>
    /// Adds ClashRoyaleApiClient to the service collection using <see cref="ApiOptions"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="apiOptions">The API options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, ApiOptions apiOptions) =>
        services.AddClashRoyaleApiClient(_ => apiOptions);

    /// <summary>
    /// Adds ClashRoyaleApiClient to the service collection using a function to configure <see cref="ApiOptions"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="apiOptionsFactory">A function to configure the API options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, Func<IServiceProvider, ApiOptions> apiOptionsFactory)
    {
        services.AddTransient(apiOptionsFactory);
        services.AddHttpClient("ClashRoyaleApi", (provider, httpClient) =>
        {
            var apiOptions = provider.GetRequiredService<ApiOptions>();
            httpClient.ConfigureApiOptions(apiOptions);
        });

        // Register all services related to ClashRoyaleApiClient
        RegisterClashRoyaleApiServices(services);

        return services;
    }

    /// <summary>
    /// Registers all services related to ClashRoyaleApiClient.
    /// </summary>
    /// <param name="services">The service collection.</param>
    private static void RegisterClashRoyaleApiServices(IServiceCollection services)
    {
        services.AddTransient<IClansService, ClansService>()
                .AddTransient<ICardsService, CardsService>()
                .AddTransient<IChallengesService, ChallengesService>()
                .AddTransient<IGlobalTournamentsService, GlobalTournamentsService>()
                .AddTransient<ILocationsService, LocationsService>()
                .AddTransient<IPlayersService, PlayersService>()
                .AddTransient<ITournamentsService, TournamentsService>()
                .AddTransient<IFilesService, FilesService>()
                .AddTransient<ILeaderboardsService, LeaderboardsService>();
    }
}
