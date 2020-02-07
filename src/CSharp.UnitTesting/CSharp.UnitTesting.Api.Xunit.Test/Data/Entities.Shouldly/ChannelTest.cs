using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entities")]
    public class ChannelTest
    {
        [Fact]
        [Trait("Entities", "Channel")]
        internal void GivenChannelEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var channels = dataFaker.FakeChannel.Generate(count: 999);

            // Assert
            channels.ForEach(
                channel => channel.ShouldSatisfyAllConditions(
                    () => channel.Id.ShouldNotBeNull(),
                    () => channel.Id.ShouldBeGreaterThanOrEqualTo(1),
                    () => channel.Name.ShouldNotBeNullOrEmpty(),
                    () => channel.Name.Length.ShouldBeInRange(1, 50),
                    () => channel.Description.ShouldNotBeNullOrEmpty(),
                    () => channel.Description.Length.ShouldBeInRange(1, 100),
                    () => channel.Avatar.ShouldNotBeNull(),
                    () => channel.Avatar.Length.ShouldBeGreaterThanOrEqualTo(0),
                    () => channel.OwnerEmail.ShouldNotBeNullOrEmpty(),
                    () => channel.OwnerEmail.ShouldContain('@'),
                    () => channel.Subscriptions.ShouldNotBeNull(),
                    () => channel.Subscriptions.ShouldBeAssignableTo<IEnumerable<Subscription>>(),
                    () => channel.Subscriptions.ShouldNotBeEmpty(),
                    () => channel.Videos.ShouldNotBeNull(),
                    () => channel.Videos.ShouldBeAssignableTo<IEnumerable<Video>>(),
                    () => channel.Videos.ShouldNotBeEmpty(),
                    () => channel.IsDeleted.ShouldNotBeNull()));
        }
    }
}
