using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entity | Channel")]
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
            channels.ForEach(
                channel => channel.ShouldSatisfyAllConditions(
                    () => channel.Id.ShouldNotBeNull(),
                    () => channel.Id.ShouldBeGreaterThanOrEqualTo(1, "because it is PK"),
                    () => channel.Name.ShouldNotBeNullOrEmpty("because it is required"),
                    () => channel.Name.Length.ShouldBeInRange(1, 50),
                    () => channel.Description.ShouldNotBeNullOrEmpty("because it is required"),
                    () => channel.Description.Length.ShouldBeInRange(1, 100),
                    () => channel.Avatar.ShouldNotBeNull("because it is required"),
                    () => channel.Avatar.ShouldNotBeEmpty(),
                    () => channel.OwnerEmail.ShouldNotBeNullOrEmpty(),
                    () => channel.OwnerEmail.ShouldContain('@'),
                    () => channel.Subscriptions.ShouldNotBeNull("because it is required"),
                    () => channel.Subscriptions.ShouldNotBeEmpty(),
                    () => channel.Subscriptions.ShouldBeAssignableTo<IEnumerable<Subscription>>(),
                    () => channel.Videos.ShouldNotBeNull(),
                    () => channel.Videos.ShouldNotBeEmpty(),
                    () => channel.Videos.ShouldBeAssignableTo<IEnumerable<Video>>(),
                    () => channel.IsDeleted.ShouldNotBeNull("because it is required")));
        }
    }
}
