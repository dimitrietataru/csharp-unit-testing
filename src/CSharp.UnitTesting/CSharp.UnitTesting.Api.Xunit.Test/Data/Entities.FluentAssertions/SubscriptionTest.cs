using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit + FluentAssertions | Data | Entities", nameof(Subscription))]
    public sealed class SubscriptionTest
    {
        [Fact]
        internal void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 10);

            // Assert
            subscriptions.ForEach(subscription =>
            {
                subscription.Id.Should().NotBeEmpty();
                subscription.ChannelId.Should().NotBe(null).And.BeGreaterOrEqualTo(1);
                subscription.UserEmail.Should().NotBeNullOrEmpty().And.Contain("@");
                subscription.SubscribedAt.Should().BeOnOrAfter(DateTime.UtcNow.AddDays(-365));
                subscription.SubscribedAt.Should().BeOnOrBefore(DateTime.UtcNow);
            });
        }
    }
}
