using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access tournament information
/// </summary>
public interface ITournamentsService
{
    /// <summary>
    /// Get information about a single tournament by a tournament tag.
    /// </summary>
    /// <param name="tournamentTag">Tag of the tournament to retrieve</param>
    /// <returns></returns>
    Task<Tournament?> GetTournamentAsync(string tournamentTag);

    /// <summary>
    /// Search all tournaments by name.
    /// </summary>
    /// <param name="name">Search clans by name. If name is used as part of search query, it needs to be at least three characters long. Name search parameter is interpreted as wild card search, so it may appear anywhere in the clan name.</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<TournamentHeaderList?> SearchAsync(string? name, int? limit = null, string? after = null, string? before = null);
}
