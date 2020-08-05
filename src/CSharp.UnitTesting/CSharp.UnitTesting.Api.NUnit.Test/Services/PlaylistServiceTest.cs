using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CSharp.UnitTesting.Api.NUnit.Test.Services
{
    [Property("NUnit + Default | Services", nameof(PlaylistService))]
    public sealed class PlaylistServiceTest
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

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.GetAllAsync());

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenGetByIdAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.GetByIdAsync(It.IsAny<Guid>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenGetByIdsAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.GetByIdsAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenCreateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.CreateAsync(It.IsAny<Playlist>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenCreateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.CreateBulkAsync(It.IsAny<IEnumerable<Playlist>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenUpdateAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenUpdateBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.UpdateBulkAsync(It.IsAny<IEnumerable<Playlist>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenDeleteAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.DeleteAsync(It.IsAny<Guid>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }

        [Test]
        public void GivenDeleteBulkAsyncWhenExpectedExceptionIsThrownThenHandlesGracefully()
        {
            // Arrange

            // Act
            var exception = Assert.ThrowsAsync<NotImplementedException>(
                () => playlistService.DeleteBulkAsync(It.IsAny<IEnumerable<Guid>>()));

            // Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception, Is.TypeOf<NotImplementedException>());
        }
    }
}
