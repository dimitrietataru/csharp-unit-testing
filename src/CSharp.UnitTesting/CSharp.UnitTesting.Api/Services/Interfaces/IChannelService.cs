using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services.Interfaces
{
    public interface IChannelService : IServiceBase<Channel, int>
    {
        Task<IEnumerable<Channel>> GetTopAsync(int count);
    }
}
