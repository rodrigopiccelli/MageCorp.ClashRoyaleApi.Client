﻿using MageCorp.ClashRoyaleApi.Client.Model.Abstract;

namespace MageCorp.ClashRoyaleApi.Client.Model;

/// <summary>
/// </summary>
public class CardList: ApiPagedResponse<Card>
{
    /// <summary>
    /// </summary>
    public List<Card>? SupportItems { get; internal set; }
}
