using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit + FluentAssertions | Data | Entities", nameof(Channel))]
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
                channel.Id.Should().NotBe(null).And.BeGreaterOrEqualTo(1);
                channel.Name.Should().NotBeNullOrEmpty();
                channel.Name.Length.Should().BeInRange(1, 50);
                channel.Description.Should().NotBeNullOrEmpty();
                channel.Description.Length.Should().BeInRange(1, 100);
                channel.Avatar.Should().NotBeNullOrEmpty();
                channel.OwnerEmail.Should().NotBeNullOrEmpty().And.Contain("@");
                channel.Subscriptions.Should().NotBeNull().And.BeAssignableTo<IEnumerable<Subscription>>();
                channel.Subscriptions.Should().NotBeEmpty().And.HaveCount(3);
                channel.Videos.Should().NotBeNull().And.BeAssignableTo<IEnumerable<Video>>();
                channel.Videos.Should().NotBeEmpty().And.HaveCount(3);
            });
        }
    }
}
