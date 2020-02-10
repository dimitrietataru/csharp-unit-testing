using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit | FluentAssertions", "Entities")]
    public class ChannelTest
    {
        [Fact]
        internal void GivenChannelEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var channels = dataFaker.FakeChannel.Generate(count: 99);

            // Assert
            channels.ForEach(channel =>
            {
                channel.Id.Should().NotBe(null);
                channel.Id.Should().BeGreaterOrEqualTo(1, "because it is PK");
                channel.Name.Should().NotBeNullOrEmpty("because it is required");
                channel.Name.Length.Should().BeInRange(1, 50);
                channel.Description.Should().NotBeNullOrEmpty("because it is required");
                channel.Description.Length.Should().BeInRange(1, 100);
                channel.Avatar.Should().NotBeNullOrEmpty("because it is required");
                channel.OwnerEmail.Should().NotBeNullOrEmpty("because it is required");
                channel.OwnerEmail.Should().Contain("@");
                channel.Subscriptions.Should().NotBeNullOrEmpty();
                channel.Subscriptions.Should().AllBeAssignableTo<Subscription>();
                channel.Videos.Should().NotBeNullOrEmpty();
                channel.Videos.Should().AllBeAssignableTo<Video>();
            });
        }
    }
}
