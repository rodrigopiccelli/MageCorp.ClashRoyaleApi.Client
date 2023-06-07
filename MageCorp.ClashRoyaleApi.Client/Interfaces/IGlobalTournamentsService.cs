using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

public interface IGlobalTournamentsService
{
    /// <summary>
    /// Get list of global tournaments
    /// </summary>
    /// <returns></returns>
    Task<LadderTournamentList> ListGlobalTournamentsAsync();
}
