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
    [Trait("xUnit + Default | Services", nameof(PlaylistService))]
    public sealed class PlaylistServiceTest
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

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.GetAllAsync());

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.GetByIdAsync(It.IsAny<Guid>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.CreateAsync(It.IsAny<Playlist>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.CreateBulkAsync(It.IsAny<IEnumerable<Playlist>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.UpdateBulkAsync(It.IsAny<IEnumerable<Playlist>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.DeleteAsync(It.IsAny<Guid>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }

        [Fact]
        internal async Task GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = await Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<NotImplementedException>(exception);
        }
    }
}
