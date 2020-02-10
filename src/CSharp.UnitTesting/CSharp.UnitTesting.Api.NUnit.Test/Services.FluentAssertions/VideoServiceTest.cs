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
    [Property("NUnit | FluentAssertions", "Service | Video")]
    public class VideoServiceTest
    {
        private readonly IVideoService videoService;

        public VideoServiceTest()
        {
            videoService = new VideoService();
        }

        [Test]
        public void GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetAllAsync();

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetByIdAsync(It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByChannelIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.GetByChannelIdAsync(It.IsAny<int>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.CreateAsync(It.IsAny<Video>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.CreateBulkAsync(It.IsAny<IEnumerable<Video>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.UpdateBulkAsync(It.IsAny<IEnumerable<Video>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.DeleteAsync(It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await videoService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.Should().NotBeNull().And.BeOfType<NotImplementedException>();
        }
    }
}
