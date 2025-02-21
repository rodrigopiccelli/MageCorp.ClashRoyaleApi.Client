using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access challenge information
/// </summary>
public interface IChallengesService
{
    /// <summary>
    /// Get current and upcoming challenges.
    /// </summary>
    /// <returns></returns>
    Task<ChallengeChainsList> ListChallengesAsync();
}
