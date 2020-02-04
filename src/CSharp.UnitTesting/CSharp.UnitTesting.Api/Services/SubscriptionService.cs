using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services
{
    public sealed class SubscriptionService : ISubscriptionService
    {
        public Task<IEnumerable<Subscription>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetByIdsAsync(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetByChannelIdAsync(int channelId)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public Task CreateBulkAsync(IEnumerable<Subscription> subscriptions)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Subscription subscription, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBulkAsync(IEnumerable<Subscription> subscriptions)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBulkAsync(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
