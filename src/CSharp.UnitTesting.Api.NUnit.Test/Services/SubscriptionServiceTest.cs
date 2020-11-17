﻿using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CSharp.UnitTesting.Api.NUnit.Test.Services
{
    [Property("NUnit + Default | Services", nameof(SubscriptionService))]
    public sealed class SubscriptionServiceTest
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

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetAllAsync());

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetByIdAsync(It.IsAny<Guid>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.GetByChannelIdAsync(It.IsAny<int>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.CreateAsync(It.IsAny<Subscription>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.CreateBulkAsync(It.IsAny<IEnumerable<Subscription>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.UpdateBulkAsync(It.IsAny<IEnumerable<Subscription>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.DeleteAsync(It.IsAny<Guid>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => subscriptionService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }
    }
}
