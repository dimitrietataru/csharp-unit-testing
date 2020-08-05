using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit + Shouldly | Data | Entities", nameof(Channel))]
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
            channels.ForEach(
                channel => channel.ShouldSatisfyAllConditions(
                    () => channel.Id.ShouldNotBeNull(),
                    () => channel.Id.ShouldBeGreaterThanOrEqualTo(1),
                    () => channel.Name.ShouldNotBeNullOrEmpty(),
                    () => channel.Name.Length.ShouldBeInRange(1, 50),
                    () => channel.Description.ShouldNotBeNullOrEmpty(),
                    () => channel.Description.Length.ShouldBeInRange(1, 100),
                    () => channel.Avatar.ShouldNotBeNull(),
                    () => channel.Avatar.ShouldNotBeEmpty(),
                    () => channel.OwnerEmail.ShouldNotBeNullOrEmpty(),
                    () => channel.OwnerEmail.ShouldContain('@'),
                    () => channel.Subscriptions.ShouldNotBeNull(),
                    () => channel.Subscriptions.ShouldBeAssignableTo<IEnumerable<Subscription>>(),
                    () => channel.Subscriptions.ShouldNotBeEmpty(),
                    () => channel.Subscriptions.Count().ShouldBe(3),
                    () => channel.Videos.ShouldNotBeNull(),
                    () => channel.Videos.ShouldBeAssignableTo<IEnumerable<Video>>(),
                    () => channel.Videos.ShouldNotBeEmpty(),
                    () => channel.Videos.Count().ShouldBe(3),
                    () => channel.IsDeleted.ShouldNotBeNull(),
                    () => channel.IsDeleted.ShouldBeOneOf(true, false)));
        }
    }
}
