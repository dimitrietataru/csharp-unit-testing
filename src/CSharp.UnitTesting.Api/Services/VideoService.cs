using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services
{
    public sealed class VideoService : IVideoService
    {
        public Task<IEnumerable<Video>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Video> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Video>> GetByIdsAsync(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Video>> GetByChannelIdAsync(int channelId)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Video video)
        {
            throw new NotImplementedException();
        }

        public Task CreateBulkAsync(IEnumerable<Video> videos)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Video video, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBulkAsync(IEnumerable<Video> videos)
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
