﻿using Nop.Core.Domain.Orders;
using Nop.Services.Caching;

namespace Nop.Services.Orders.CacheEventConsumers
{
    /// <summary>
    /// Represents a checkout attribute value cache event consumer
    /// </summary>
    public partial class CheckoutAttributeValueCacheEventConsumer : CacheEventConsumer<CheckoutAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CheckoutAttributeValue entity)
        {
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopOrderDefaults.CheckoutAttributeValuesAllCacheKey, entity.CheckoutAttributeId);
            Remove(cacheKey);
        }
    }
}
