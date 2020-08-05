using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using NUnit.Framework;
using System;

namespace CSharp.UnitTesting.Api.NUnit.Test.Data.Entities
{
    [Property("NUnit + Default | Data | Entities", nameof(Subscription))]
    public sealed class SubscriptionTest
    {
        [Test]
        public void GivenSubscriptionEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var subscriptions = dataFaker.FakeSubscription.Generate(count: 10);

            // Assert
            subscriptions.ForEach(subscription =>
            {
                Assert.That(subscription.Id, Is.Not.Null);
                Assert.That(subscription.Id, Is.Not.EqualTo(Guid.Empty));
                Assert.That(subscription.ChannelId, Is.Not.Null);
                Assert.That(subscription.ChannelId, Is.GreaterThanOrEqualTo(1));
                Assert.That(subscription.UserEmail, Is.Not.Null);
                Assert.That(subscription.UserEmail, Is.Not.Empty);
                Assert.That(subscription.UserEmail, Does.Contain("@"));
                Assert.That(subscription.SubscribedAt, Is.Not.Null);
                Assert.That(subscription.SubscribedAt, Is.GreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)));
                Assert.That(subscription.SubscribedAt, Is.LessThanOrEqualTo(DateTime.UtcNow));
                Assert.That(subscription.IsDeleted, Is.Not.Null);
                Assert.That(subscription.IsDeleted, Is.TypeOf<bool>());
            });
        }
    }
}
