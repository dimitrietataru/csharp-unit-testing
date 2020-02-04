using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services
{
    public sealed class PlaylistService : IPlaylistService
    {
        public Task<IEnumerable<Playlist>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Playlist> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Playlist>> GetByIdsAsync(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Playlist playlist)
        {
            throw new NotImplementedException();
        }

        public Task CreateBulkAsync(IEnumerable<Playlist> playlists)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Playlist playlist, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBulkAsync(IEnumerable<Playlist> playlists)
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
