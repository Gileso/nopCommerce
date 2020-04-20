﻿using Nop.Core.Domain.Forums;
using Nop.Services.Caching;

namespace Nop.Services.Forums.CacheEventConsumers
{
    /// <summary>
    /// Represents a forum post cache event consumer
    /// </summary>
    public partial class ForumPostCacheEventConsumer : CacheEventConsumer<ForumPost>
    {
    }
}
