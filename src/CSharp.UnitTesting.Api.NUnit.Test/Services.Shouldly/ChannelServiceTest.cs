﻿using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Moq;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.NUnit.Test.Services.Shouldly
{
    [Property("NUnit + Shouldly | Services", nameof(ChannelService))]
    public sealed class ChannelServiceTest
    {
        private readonly IChannelService channelService;

        public ChannelServiceTest()
        {
            channelService = new ChannelService();
        }

        [Test]
        public void GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetAllAsync());

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetByIdAsync(It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetByIdsAsync(It.IsAny<IEnumerable<int>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetTopAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetTopAsync(It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.CreateAsync(It.IsAny<Channel>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.CreateBulkAsync(It.IsAny<IEnumerable<Channel>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.UpdateBulkAsync(It.IsAny<IEnumerable<Channel>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.DeleteAsync(It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.DeleteBulkAsync(It.IsAny<IEnumerable<int>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }
    }
}
