using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace CSharp.UnitTesting.Api.NUnit.Test.Data.Entities
{
    [Property("NUnit + Default | Data | Entities", nameof(Channel))]
    public sealed class ChannelTest
    {
        [Test]
        public void GivenChannelEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var channels = dataFaker.FakeChannel.Generate(count: 10);

            // Assert
            channels.ForEach(channel =>
            {
                Assert.That(channel.Id, Is.Not.Null);
                Assert.That(channel.Id, Is.GreaterThanOrEqualTo(1));
                Assert.That(channel.Name, Is.Not.Null);
                Assert.That(channel.Name, Is.Not.Empty);
                Assert.That(channel.Name.Length, Is.InRange(1, 50));
                Assert.That(channel.Description, Is.Not.Null);
                Assert.That(channel.Description, Is.Not.Empty);
                Assert.That(channel.Description.Length, Is.InRange(1, 100));
                Assert.That(channel.Avatar, Is.Not.Null);
                Assert.That(channel.Avatar, Is.Not.Empty);
                Assert.That(channel.OwnerEmail, Is.Not.Null);
                Assert.That(channel.OwnerEmail, Is.Not.Empty);
                Assert.That(channel.OwnerEmail, Does.Contain("@"));
                Assert.That(channel.Subscriptions, Is.Not.Null);
                Assert.That(channel.Subscriptions, Is.InstanceOf<IEnumerable<Subscription>>());
                Assert.That(channel.Subscriptions, Is.Not.Empty);
                Assert.That(channel.Subscriptions, Has.Count.EqualTo(3));
                Assert.That(channel.Videos, Is.Not.Null);
                Assert.That(channel.Videos, Is.InstanceOf<IEnumerable<Video>>());
                Assert.That(channel.Videos, Is.Not.Empty);
                Assert.That(channel.Videos, Has.Count.EqualTo(3));
                Assert.That(channel.IsDeleted, Is.Not.Null);
                Assert.That(channel.IsDeleted, Is.TypeOf<bool>());
            });
        }
    }
}
