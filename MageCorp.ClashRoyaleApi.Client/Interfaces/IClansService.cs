using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access clan specific information
/// </summary>
public interface IClansService
{
    /// <summary>
    /// Retrieve clan's clan war log
    /// </summary>
    /// <param name="clanTag">Tag of the clan.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<ClanWarLog> ListWarlogAsync(string clanTag, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Search all clans by name and/or filtering the results using various criteria. At least one filtering criteria must be defined.
    /// </summary>
    /// <param name="name">Search clans by name. If name is used as part of search query, it needs to be at least three characters long. Name search parameter is interpreted as wild card search, so it may appear anywhere in the clan name.</param>
    /// <param name="locationId">Filter by clan location identifier. For list of available locations, refer to getLocations operation.</param>
    /// <param name="minMembers">Filter by minimum number of clan members</param>
    /// <param name="maxMambers">Filter by maximum number of clan members</param>
    /// <param name="minScore">Filter by minimum amount of clan score.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<ClanList> SearchAsync(string? name = null, int? locationId = null, int? minMembers = null, int? maxMambers = null, int? minScore = null, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Retrieve clan's river race log
    /// </summary>
    /// <param name="clanTag">Tag of the clan.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<RiverRaceLog> ListRiverRaceLogAsync(string clanTag, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Retrieve information about clan's current clan war
    /// </summary>
    /// <param name="clanTag">Tag of the clan.</param>
    /// <returns></returns>
    Task<CurrentClanWar> GetCurrentWarAsync(string clanTag);
    /// <summary>
    /// Get information about a single clan by clan tag. Clan tags can be found using clan search operation.
    /// </summary>
    /// <param name="clanTag">Tag of the clan.</param>
    /// <returns></returns>
    Task<Clan> GetAsync(string clanTag);
    /// <summary>
    /// List clan members.
    /// </summary>
    /// <param name="clanTag">Tag of the clan.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<ClanMemberList> ListMembersAsync(string clanTag, int? limit = null, string? after = null, string? before = null);
    /// <summary>
    /// Retrieve information about clan's current river race
    /// </summary>
    /// <param name="clanTag">Tag of the clan.</param>
    /// <returns></returns>
    Task<CurrentRiverRace> GetCurrentRiverRaceAsync(string clanTag);
}
