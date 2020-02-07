using Bogus;
using CSharp.UnitTesting.Api.Data.Entities;

namespace CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces
{
    public interface IDataFaker
    {
        Faker<Channel> FakeChannel { get; }
        Faker<Playlist> FakePlaylist { get; }
        Faker<Subscription> FakeSubscription { get; }
        Faker<Video> FakeVideo { get; }
    }
}
