using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Services
{
    [Trait("xUnit", "Service | Channel")]
    public class ChannelServiceTest
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
            async Task action() => await channelService.GetAllAsync();

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.GetByIdAsync(It.IsAny<int>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.GetByIdsAsync(It.IsAny<IEnumerable<int>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetTopAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.GetTopAsync(It.IsAny<int>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.CreateAsync(It.IsAny<Channel>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.CreateBulkAsync(It.IsAny<IEnumerable<Channel>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.UpdateBulkAsync(It.IsAny<IEnumerable<Channel>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.DeleteAsync(It.IsAny<int>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await channelService.DeleteBulkAsync(It.IsAny<IEnumerable<int>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }
    }
}
