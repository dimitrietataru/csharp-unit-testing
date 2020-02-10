using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities
{
    [Trait("xUnit", "Entities")]
    public class ChannelTest
    {
        [Fact]
        [Trait("Entities", "Channel")]
        internal void GivenChannelEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var channels = dataFaker.FakeChannel.Generate(count: 99);

            // Assert
            channels.ForEach(channel =>
            {
                ////Assert.NotNull(channel.Id);
                Assert.True(channel.Id >= 1);
                Assert.NotNull(channel.Description);
                Assert.NotEmpty(channel.Description);
                Assert.True(channel.Description.Length >= 1);
                Assert.True(channel.Description.Length <= 100);
                Assert.NotNull(channel.Avatar);
                Assert.True(channel.Avatar.Length >= 0);
                Assert.NotNull(channel.OwnerEmail);
                Assert.NotEmpty(channel.OwnerEmail);
                Assert.Contains('@', channel.OwnerEmail);
                Assert.NotNull(channel.Subscriptions);
                Assert.IsAssignableFrom<IEnumerable<Subscription>>(channel.Subscriptions);
                Assert.NotEmpty(channel.Subscriptions);
                Assert.NotNull(channel.Videos);
                Assert.IsAssignableFrom<IEnumerable<Video>>(channel.Videos);
                Assert.NotEmpty(channel.Videos);
                ////Assert.NotNull(channel.IsDeleted);
            });
        }
    }
}
