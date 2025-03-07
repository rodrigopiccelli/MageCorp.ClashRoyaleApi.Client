using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access player specific information
/// </summary>
public interface IPlayersService
{
    /// <summary>
    /// Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists.
    /// </summary>
    /// <param name="playerTag">Tag of the player.</param>
    /// <returns></returns>
    Task<Player> GetPlayerAsync(string playerTag);
    /// <summary>
    /// Get list of reward chests that the player will receive next in the game.
    /// </summary>
    /// <param name="playerTag">Tag of the player.</param>
    /// <returns></returns>
    Task<UpcomingChests> GetUpcomingChestsAsync(string playerTag);
    /// <summary>
    /// Get list of recent battles for a player
    /// </summary>
    /// <param name="playerTag">Tag of the player.</param>
    /// <returns></returns>
    Task<BattleList> ListBatlleLogAsync(string playerTag);

    /// <summary>
    /// Get information about a single player by player tag. Player tags can be found either in game or by from clan member lists.
    /// </summary>
    /// <param name="playerTag">Tag of the player.</param>
    /// <returns></returns>
    Player GetPlayer(string playerTag);

    /// <summary>
    /// Get list of reward chests that the player will receive next in the game.
    /// </summary>
    /// <param name="playerTag">Tag of the player.</param>
    /// <returns></returns>
    UpcomingChests GetUpcomingChests(string playerTag);

    /// <summary>
    /// Get list of recent battles for a player
    /// </summary>
    /// <param name="playerTag">Tag of the player.</param>
    /// <returns></returns>
    BattleList ListBatlleLog(string playerTag);
}
