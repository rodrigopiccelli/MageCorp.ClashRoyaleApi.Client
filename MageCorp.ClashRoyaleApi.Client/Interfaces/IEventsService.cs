using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access current events information
/// </summary>
public interface IEventsService
{
    /// <summary>
    /// Get current and upcoming trail events.
    /// </summary>
    /// <returns></returns>
    Task<TrailEventList> ListEventsAsync();

    /// <summary>
    /// Get current and upcoming trail events.
    /// </summary>
    /// <returns></returns>
    TrailEventList ListEvents();
}
