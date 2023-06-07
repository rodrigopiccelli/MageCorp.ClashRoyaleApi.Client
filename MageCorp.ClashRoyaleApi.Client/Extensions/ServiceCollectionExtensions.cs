using MageCorp.ClashRoyaleApi.Client.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MageCorp.ClashRoyaleApi.Client.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, string apiKey) => 
        services.AddClashRoyaleApiClient(new ApiOptions(apiKey));

    public static IServiceCollection AddClashRoyaleApiClient(this IServiceCollection services, ApiOptions apiOptions) => 
        services.AddClashRoyaleApiClient(provider => apiOptions);

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
            .AddTransient<ITournamentsService, TournamentsService>();
    }
}
