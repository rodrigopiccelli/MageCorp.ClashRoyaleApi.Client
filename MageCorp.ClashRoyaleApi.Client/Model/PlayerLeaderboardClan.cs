﻿using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class PlayerLeaderboardClan
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Tag { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Name { get; internal set; }
    /// <summary>
    /// </summary>
    [JsonInclude]
    public int BadgeId { get; internal set; }
}
