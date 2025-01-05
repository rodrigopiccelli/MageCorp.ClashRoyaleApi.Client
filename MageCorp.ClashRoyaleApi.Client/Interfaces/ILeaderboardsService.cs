using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// </summary>
public interface ILeaderboardsService
{
    /// <summary>
    /// List leaderboards for different trophy roads
    /// </summary>
    /// <returns></returns>
    public Task<LeaderboardList?> ListLeaderboardsAsync();

    /// <summary>
    /// Get players on a specific leaderboard
    /// </summary>
    /// <param name="leaderboardId">A leaderboard ID from leaderboard API</param>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    public Task<PlayerLeaderboardList?> GetLeaderboardAsync(long leaderboardId, int? limit = null, string? after = null, string? before = null);
}
