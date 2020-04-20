﻿using Nop.Core.Domain.Orders;
using Nop.Services.Caching;

namespace Nop.Services.Orders.CacheEventConsumers
{
    /// <summary>
    /// Represents a gift card cache event consumer
    /// </summary>
    public partial class GiftCardCacheEventConsumer : CacheEventConsumer<GiftCard>
    {
    }
}
