using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.NUnit.Test.Services.FluentAssertions
{
    [Property("NUnit | FluentAssertions", "Service | Subscription")]
    public class SubscriptionServiceTest
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionServiceTest()
        {
            subscriptionService = new SubscriptionService();
        }

        [Test]
        public void GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetAllAsync();

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetByIdAsync(It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetByChannelIdAsync(It.IsAny<int>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.CreateAsync(It.IsAny<Subscription>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.CreateBulkAsync(It.IsAny<IEnumerable<Subscription>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.UpdateBulkAsync(It.IsAny<IEnumerable<Subscription>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.DeleteAsync(It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }
    }
}
