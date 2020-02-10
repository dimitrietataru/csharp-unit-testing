using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entity | Subscription")]
    public class SubscriptionTest
    {
        [Fact]
        internal void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 999);

            // Assert
            subscriptions.ForEach(
                subscription => subscription.ShouldSatisfyAllConditions(
                    () => subscription.Id.ShouldNotBeNull(),
                    () => subscription.Id.ShouldNotBe(Guid.Empty, "because it is PK"),
                    () => subscription.ChannelId.ShouldNotBeNull(),
                    () => subscription.ChannelId.ShouldBeGreaterThanOrEqualTo(1, "because it is FK"),
                    () => subscription.UserEmail.ShouldNotBeNullOrEmpty("because it is required"),
                    () => subscription.UserEmail.ShouldContain('@'),
                    () => subscription.SubscribedAt.ShouldBeInRange(DateTime.UtcNow.AddDays(-365), DateTime.UtcNow),
                    () => subscription.IsDeleted.ShouldNotBeNull("because it is required")));
        }
    }
}
