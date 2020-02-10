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
    [Property("NUnit | FluentAssertions", "Service | Channel")]
    public class ChannelServiceTest
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
            async Task action() => await channelService.GetAllAsync();

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.GetByIdAsync(It.IsAny<int>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.GetByIdsAsync(It.IsAny<IEnumerable<int>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetTopAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.GetTopAsync(It.IsAny<int>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.CreateAsync(It.IsAny<Channel>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.CreateBulkAsync(It.IsAny<IEnumerable<Channel>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.UpdateBulkAsync(It.IsAny<IEnumerable<Channel>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.DeleteAsync(It.IsAny<int>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.DeleteBulkAsync(It.IsAny<IEnumerable<int>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }
    }
}
