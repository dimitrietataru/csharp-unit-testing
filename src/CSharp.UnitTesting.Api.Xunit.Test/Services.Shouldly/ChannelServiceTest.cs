using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Services.Shouldly
{
    [Trait("xUnit + Shouldly | Services", nameof(ChannelService))]
    public sealed class ChannelServiceTest
    {
        private readonly IChannelService channelService;

        public ChannelServiceTest()
        {
            channelService = new ChannelService();
        }

        [Fact]
        internal async Task GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetAllAsync());

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetByIdAsync(It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetByIdsAsync(It.IsAny<IEnumerable<int>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetTopAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.GetTopAsync(It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.CreateAsync(It.IsAny<Channel>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.CreateBulkAsync(It.IsAny<IEnumerable<Channel>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.UpdateBulkAsync(It.IsAny<IEnumerable<Channel>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.DeleteAsync(It.IsAny<int>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => channelService.DeleteBulkAsync(It.IsAny<IEnumerable<int>>()));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }
    }
}
