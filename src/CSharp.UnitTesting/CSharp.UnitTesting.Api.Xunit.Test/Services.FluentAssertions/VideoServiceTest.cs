using CSharp.UnitTesting.Api.Data.Entities;
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
    [Trait("xUnit | FluentAssertions", "Service | Video")]
    public class VideoServiceTest
    {
        private readonly IVideoService videoService;

        public VideoServiceTest()
        {
            videoService = new VideoService();
        }

        [Fact]
        internal async Task GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetAllAsync();

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetByIdAsync(It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetByChannelIdAsync(It.IsAny<int>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.CreateAsync(It.IsAny<Video>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.CreateBulkAsync(It.IsAny<IEnumerable<Video>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.UpdateBulkAsync(It.IsAny<IEnumerable<Video>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.DeleteAsync(It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }
    }
}
