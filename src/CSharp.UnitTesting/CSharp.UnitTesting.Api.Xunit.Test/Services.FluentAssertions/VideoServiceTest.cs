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
    [Trait("xUnit + FluentAssertions | Services", nameof(VideoService))]
    public sealed class VideoServiceTest
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

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.GetAllAsync());

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.GetByIdAsync(It.IsAny<Guid>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.GetByChannelIdAsync(It.IsAny<int>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.CreateAsync(It.IsAny<Video>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.CreateBulkAsync(It.IsAny<IEnumerable<Video>>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.UpdateBulkAsync(It.IsAny<IEnumerable<Video>>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.DeleteAsync(It.IsAny<Guid>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => videoService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }
    }
}
