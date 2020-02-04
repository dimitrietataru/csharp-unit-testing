using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces.Base;
using System;

namespace CSharp.UnitTesting.Api.Services.Interfaces
{
    public interface IPlaylistService : IServiceBase<Playlist, Guid>
    {
    }
}
