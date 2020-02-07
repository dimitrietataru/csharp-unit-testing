using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entities")]
    public class SubscriptionTest
    {
        [Fact]
        [Trait("Entities", "Subscription")]
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
                    () => subscription.Id.ShouldNotBe(Guid.Empty),
                    () => subscription.ChannelId.ShouldNotBeNull(),
                    () => subscription.ChannelId.ShouldBeGreaterThanOrEqualTo(1),
                    () => subscription.UserEmail.ShouldNotBeNullOrEmpty(),
                    () => subscription.UserEmail.ShouldContain('@'),
                    () => subscription.SubscribedAt.ShouldBeGreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)),
                    () => subscription.SubscribedAt.ShouldBeLessThanOrEqualTo(DateTime.UtcNow),
                    () => subscription.IsDeleted.ShouldNotBeNull()));
        }
    }
}
