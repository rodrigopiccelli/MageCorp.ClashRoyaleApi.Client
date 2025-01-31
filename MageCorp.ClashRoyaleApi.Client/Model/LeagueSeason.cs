﻿using MageCorp.ClashRoyaleApi.Client.Model.Abstract;
using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class LeagueSeason : ApiResponse
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public string? Id { get; internal set; }
}
