using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities
{
    [Trait("xUnit", "Entities")]
    public class SubscriptionTest
    {
        [Fact]
        [Trait("Entities", "Subscription")]
        internal void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 99);

            // Assert
            subscriptions.ForEach(subscription =>
            {
                ////Assert.NotNull(subscription.Id);
                Assert.NotEqual(Guid.Empty, subscription.Id);
                ////Assert.NotNull(subscription.ChannelId);
                Assert.True(subscription.ChannelId >= 1);
                Assert.NotNull(subscription.UserEmail);
                Assert.NotEmpty(subscription.UserEmail);
                Assert.Contains('@', subscription.UserEmail);
                Assert.True(subscription.SubscribedAt >= DateTime.UtcNow.AddDays(-365));
                Assert.True(subscription.SubscribedAt <= DateTime.UtcNow);
                ////Assert.NotNull(subscription.IsDeleted);
            });
        }
    }
}
