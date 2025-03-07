using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access global and local rankings
/// </summary>
public interface ILocationsService
{
    /// <summary>
    /// Get clan rankings for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<ClanRankingList> ListClanRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get player rankings for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<PlayerRankingList> ListPlayerRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get clan war rankings for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<ClanRankingList> ListClanWarRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get top Path of Legend players for given season.
    /// </summary>
    /// <param name="seasonId">Identifier of the season.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<PlayerPathOfLegendRankingList> ListPlayerPathOfLegendRankingsAsync(string seasonId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get player rankings in Path of Legend for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<PlayerPathOfLegendRankingList> ListPlayerPathOfLegendRankingsAsync(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get top player league season.
    /// </summary>
    /// <param name="seasonId">Identifier of the season.</param>
    /// <returns></returns>
    Task<LeagueSeason> GetLeagueSeasonAsync(string seasonId);
    /// <summary>
    /// Get top player rankings for a season.
    /// </summary>
    /// <param name="seasonId">Identifier of the season.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<PlayerRankingList> ListSeasonPlayerRankingsAsync(string seasonId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Lists top player league seasons.
    /// </summary>
    /// <returns></returns>
    Task<LeagueSeasonList> ListLeagueSeasonsAsync();
    /// <summary>
    /// List locations
    /// </summary>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<LocationList> ListLocationsAsync(int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get information about specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <returns></returns>
    Task<Location> GetLocationAsync(int locationId);
    /// <summary>
    /// Get global tournament rankings
    /// </summary>
    /// <param name="tournamentTag">Tag of the tournament to retrieve</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<LadderTournamentRankingList> ListLadderTournamentRankingsAsync(string tournamentTag, int? limit = null, string? after = null, string? before = null);

    /// <summary>
    /// Get clan rankings for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    ClanRankingList ListClanRankings(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get player rankings for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    PlayerRankingList ListPlayerRankings(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get clan war rankings for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    ClanRankingList ListClanWarRankings(int locationId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get top Path of Legend players for given season.
    /// </summary>
    /// <param name="seasonId">Identifier of the season.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    PlayerPathOfLegendRankingList ListPlayerPathOfLegendRankings(string seasonId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get player rankings in Path of Legend for a specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    PlayerPathOfLegendRankingList ListPlayerPathOfLegendRankings(int locationId, int? limit = null, string? after = null, string? before = null);

    /// <summary>
    /// Get top player league season.
    /// </summary>
    /// <param name="seasonId">Identifier of the season.</param>
    /// <returns></returns>
    LeagueSeason GetLeagueSeason(string seasonId);
    /// <summary>
    /// Get top player rankings for a season.
    /// </summary>
    /// <param name="seasonId">Identifier of the season.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    PlayerRankingList ListSeasonPlayerRankings(string seasonId, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Lists top player league seasons.
    /// </summary>
    /// <returns></returns>
    LeagueSeasonList ListLeagueSeasons();
    /// <summary>
    /// List locations
    /// </summary>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    LocationList ListLocations(int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Get information about specific location
    /// </summary>
    /// <param name="locationId">Identifier of the location to retrieve.</param>
    /// <returns></returns>
    Location GetLocation(int locationId);
    /// <summary>
    /// Get global tournament rankings
    /// </summary>
    /// <param name="tournamentTag">Tag of the tournament to retrieve</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    LadderTournamentRankingList ListLadderTournamentRankings(string tournamentTag, int? limit = null, string? after = null, string? before = null);
}
