using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// </summary>
public interface IGlobalTournamentsService
{
    /// <summary>
    /// Get list of global tournaments
    /// </summary>
    /// <returns></returns>
    Task<LadderTournamentList> ListGlobalTournamentsAsync();

    /// <summary>
    /// Get list of global tournaments
    /// </summary>
    /// <returns></returns>
    LadderTournamentList ListGlobalTournaments();
}
