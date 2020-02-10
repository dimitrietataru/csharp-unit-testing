using CSharp.UnitTesting.Api.Data.Entities;
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
    [Property("NUnit | Shouldly", "Service | Playlist")]
    public class PlaylistServiceTest
    {
        private readonly IPlaylistService playlistService;

        public PlaylistServiceTest()
        {
            playlistService = new PlaylistService();
        }

        [Test]
        public void GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.GetAllAsync();

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.GetByIdAsync(It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.CreateAsync(It.IsAny<Playlist>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.CreateBulkAsync(It.IsAny<IEnumerable<Playlist>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.UpdateBulkAsync(It.IsAny<IEnumerable<Playlist>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.DeleteAsync(It.IsAny<Guid>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }
    }
}
