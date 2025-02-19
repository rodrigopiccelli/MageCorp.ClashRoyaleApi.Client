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
        services.AddClashRoyaleApiClient(new ClashRoyaleApiOptions(apiKey));

    /// <summary>
    /// Adds ClashRoyaleApiClient to the service collection using <see cref="ClashRoyaleApiOptions"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="clashRoyaleApiOptions">The Clash Royale API options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, ClashRoyaleApiOptions clashRoyaleApiOptions) =>
        services.AddClashRoyaleApiClient(_ => clashRoyaleApiOptions);

    /// <summary>
    /// Adds ClashRoyaleApiClient to the service collection using a function to configure <see cref="ClashRoyaleApiOptions"/>.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="apiOptionsFactory">A function to configure the API options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, Func<IServiceProvider, ClashRoyaleApiOptions> apiOptionsFactory)
    {
        services.AddTransient(apiOptionsFactory);
        services.AddHttpClient("ClashRoyaleApiClient", (provider, httpClient) =>
        {
            var clashRoyaleApiOptions = provider.GetRequiredService<ClashRoyaleApiOptions>();
            httpClient.ConfigureClashRoyaleApiOptions(clashRoyaleApiOptions);
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
