using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using NUnit.Framework;
using System;

namespace CSharp.UnitTesting.Api.NUnit.Test.Data.Entities
{
    [Property("NUnit", "Entity | Subscription")]
    public class SubscriptionTest
    {
        [Test]
        public void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 99);

            // Assert
            subscriptions.ForEach(subscription =>
            {
                Assert.That(subscription.Id, Is.Not.Null);
                Assert.That(subscription.Id, Is.Not.EqualTo(Guid.Empty));
                Assert.That(subscription.ChannelId, Is.Not.Null);
                Assert.That(subscription.ChannelId, Is.GreaterThanOrEqualTo(1));
                Assert.That(subscription.UserEmail, Is.Not.Null);
                Assert.That(subscription.UserEmail, Is.Not.Empty);
                Assert.That(subscription.UserEmail.Contains("@"));
                Assert.That(subscription.SubscribedAt, Is.Not.Null);
                Assert.That(subscription.SubscribedAt, Is.InRange(DateTime.UtcNow.AddDays(-365), DateTime.UtcNow));
                Assert.That(subscription.IsDeleted, Is.Not.Null);
            });
        }
    }
}
