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
    [Trait("xUnit | Shouldly", "Service | Playlist")]
    public class PlaylistServiceTest
    {
        private readonly IPlaylistService playlistService;

        public PlaylistServiceTest()
        {
            playlistService = new PlaylistService();
        }

        [Fact]
        internal async Task GivenGetAllAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.GetAllAsync();

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.GetByIdAsync(It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.CreateAsync(It.IsAny<Playlist>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.CreateBulkAsync(It.IsAny<IEnumerable<Playlist>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.UpdateBulkAsync(It.IsAny<IEnumerable<Playlist>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.DeleteAsync(It.IsAny<Guid>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange
            async Task action() => await playlistService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>());

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(action);

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<NotImplementedException>();
        }
    }
}
