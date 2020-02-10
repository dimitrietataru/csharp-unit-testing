using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit | FluentAssertions", "Entity | Subscription")]
    public class SubscriptionTest
    {
        [Fact]
        internal void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 99);

            // Assert
            subscriptions.ForEach(subscription =>
            {
                subscription.Id.Should().NotBe(Guid.Empty, "because it is PK");
                subscription.ChannelId.Should().NotBe(null);
                subscription.ChannelId.Should().BeGreaterOrEqualTo(1, "because it is FK");
                subscription.UserEmail.Should().NotBeNullOrEmpty("because it is required");
                subscription.UserEmail.Should().Contain("@");
                subscription.SubscribedAt.Should().BeOnOrAfter(DateTime.UtcNow.AddDays(-365));
                subscription.SubscribedAt.Should().BeOnOrBefore(DateTime.UtcNow);
            });
        }
    }
}
