﻿using Nop.Core.Domain.Customers;
using Nop.Services.Caching;

namespace Nop.Services.Customers.CacheEventConsumers
{
    /// <summary>
    /// Represents a customer password cache event consumer
    /// </summary>
    public partial class CustomerPasswordCacheEventConsumer : CacheEventConsumer<CustomerPassword>
    {
    }
}