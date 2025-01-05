using MageCorp.ClashRoyaleApi.Client.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MageCorp.ClashRoyaleApi.Client.Extensions;

/// <summary>
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds ClashRoyaleApiClient to ServiceColletion
    /// </summary>
    /// <param name="services"></param>
    /// <param name="apiKey">Clash Royale API Key</param>
    /// <returns></returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, string apiKey) => 
        services.AddClashRoyaleApiClient(new ApiOptions(apiKey));

    /// <summary>
    /// Adds ClashRoyaleApiClient to ServiceColletion
    /// </summary>
    /// <param name="services"></param>
    /// <param name="apiOptions"></param>
    /// <returns></returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, ApiOptions apiOptions) => 
        services.AddClashRoyaleApiClient(provider => apiOptions);

    /// <summary>
    /// Adds ClashRoyaleApiClient to ServiceColletion
    /// </summary>
    /// <param name="services"></param>
    /// <param name="apiOptionsAction"></param>
    /// <returns></returns>
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, Func<IServiceProvider, ApiOptions> apiOptionsAction)
    {
        services.AddTransient(apiOptionsAction);
        services.AddHttpClient("ClashRoyaleApi", (IServiceProvider provider, HttpClient httpClient) => {
            var apiOptions = provider.GetRequiredService<ApiOptions>();
            httpClient.ConfigureApiOptions(apiOptions);
        });
        return services
            .AddTransient<IClansService, ClansService>()
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
