using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities
{
    [Trait("xUnit + Default | Data | Entities", nameof(Channel))]
    public sealed class ChannelTest
    {
        [Fact]
        internal void GivenChannelEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var channels = dataFaker.FakeChannel.Generate(count: 10);

            // Assert
            channels.ForEach(channel =>
            {
                Assert.InRange(channel.Id, 1, int.MaxValue);
                Assert.NotNull(channel.Name);
                Assert.NotEmpty(channel.Name);
                Assert.InRange(channel.Name.Length, 1, 50);
                Assert.NotNull(channel.Description);
                Assert.NotEmpty(channel.Description);
                Assert.InRange(channel.Description.Length, 1, 100);
                Assert.NotNull(channel.Avatar);
                Assert.NotEmpty(channel.Avatar);
                Assert.NotNull(channel.OwnerEmail);
                Assert.NotEmpty(channel.OwnerEmail);
                Assert.Contains('@', channel.OwnerEmail);
                Assert.NotNull(channel.Subscriptions);
                Assert.IsAssignableFrom<IEnumerable<Subscription>>(channel.Subscriptions);
                Assert.NotEmpty(channel.Subscriptions);
                Assert.Equal(3, channel.Subscriptions.Count());
                Assert.NotNull(channel.Videos);
                Assert.IsAssignableFrom<IEnumerable<Video>>(channel.Videos);
                Assert.NotEmpty(channel.Videos);
                Assert.Equal(3, channel.Videos.Count());
                Assert.IsType<bool>(channel.IsDeleted);
            });
        }
    }
}
