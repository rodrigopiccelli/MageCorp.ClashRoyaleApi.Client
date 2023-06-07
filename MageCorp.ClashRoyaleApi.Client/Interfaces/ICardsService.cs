using MageCorp.ClashRoyaleApi.Client.Model;

namespace MageCorp.ClashRoyaleApi.Client.Interfaces;

/// <summary>
/// Access card information
/// </summary>
public interface ICardsService
{
    /// <summary>
    /// Get list of available cards
    /// </summary>
    /// <param name="limit">Limit the number of items returned in the response.</param>
    /// <param name="after">Return only items that occur after this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <param name="before">Return only items that occur before this marker. Before marker can be found from the response, inside the 'paging' property. Note that only after or before can be specified for a request, not both.</param>
    /// <returns></returns>
    Task<CardList> ListAsync(int? limit = null, string? after = null, string? before = null);
}
