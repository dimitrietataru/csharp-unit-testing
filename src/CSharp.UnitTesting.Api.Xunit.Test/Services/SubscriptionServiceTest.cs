﻿using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Services
{
    [Trait("xUnit + Default | Services", nameof(SubscriptionService))]
    public sealed class SubscriptionServiceTest
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

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetAllAsync());

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetByIdAsync(It.IsAny<Guid>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetByChannelIdAsync(It.IsAny<int>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.CreateAsync(It.IsAny<Subscription>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.CreateBulkAsync(It.IsAny<IEnumerable<Subscription>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.UpdateBulkAsync(It.IsAny<IEnumerable<Subscription>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.DeleteAsync(It.IsAny<Guid>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }
    }
}
