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
        internal void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 99);

            // Assert
            subscriptions.ForEach(subscription =>
            {
                Assert.NotEqual(Guid.Empty, subscription.Id);
                Assert.InRange(subscription.ChannelId, 1, int.MaxValue);
                Assert.NotNull(subscription.UserEmail);
                Assert.NotEmpty(subscription.UserEmail);
                Assert.Contains('@', subscription.UserEmail);
                Assert.InRange(subscription.SubscribedAt, DateTime.UtcNow.AddDays(-365), DateTime.UtcNow);
            });
        }
    }
}
