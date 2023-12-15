using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CardList: ApiPagedResponse<Card>
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public List<Card>? SupportItems { get; internal set; }
}
