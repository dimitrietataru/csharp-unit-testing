﻿using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Services.FluentAssertions
{
    [Trait("xUnit | FluentAssertions", "Service | Subscription")]
    public class SubscriptionServiceTest
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionServiceTest()
        {
            subscriptionService = new SubscriptionService();
        }

        [Fact]
        internal async Task GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetAllAsync();

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetByIdAsync(It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.GetByChannelIdAsync(It.IsAny<int>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.CreateAsync(It.IsAny<Subscription>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.CreateBulkAsync(It.IsAny<IEnumerable<Subscription>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.UpdateBulkAsync(It.IsAny<IEnumerable<Subscription>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.DeleteAsync(It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await subscriptionService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }
    }
}
