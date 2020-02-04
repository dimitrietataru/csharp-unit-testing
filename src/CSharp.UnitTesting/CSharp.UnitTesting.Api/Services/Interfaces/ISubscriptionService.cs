using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services.Interfaces
{
    public interface ISubscriptionService : IServiceBase<Subscription, Guid>
    {
        Task<IEnumerable<Subscription>> GetByChannelIdAsync(int channelId);
    }
}
