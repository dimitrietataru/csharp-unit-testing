using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services
{
    public sealed class ChannelService : IChannelService
    {
        public Task<IEnumerable<Channel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Channel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Channel>> GetByIdsAsync(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Channel>> GetTopAsync(int count)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Channel channel)
        {
            throw new NotImplementedException();
        }

        public Task CreateBulkAsync(IEnumerable<Channel> channels)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Channel channel, int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBulkAsync(IEnumerable<Channel> channels)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBulkAsync(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}
