﻿using System.Text.Json.Serialization;

namespace MageCorp.ClashRoyaleApi.Client.Model.Abstract;

/// <summary>
/// </summary>
public abstract class ApiPagedResponse<T> : ApiItemizedResponse<T>
{
    /// <summary>
    /// </summary>
    [JsonInclude]
    public Paging? Paging { get; internal set; }
}
