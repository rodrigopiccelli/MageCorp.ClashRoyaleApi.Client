using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class Paging
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Cursors? Cursors { get; internal set; }
}
