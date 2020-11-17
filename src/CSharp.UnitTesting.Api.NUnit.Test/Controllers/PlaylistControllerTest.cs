using CSharp.UnitTesting.Api.Controllers;
using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.NUnit.Test.Controllers
{
    [Property("NUnit + Default | Controllers", nameof(PlaylistController))]
    public sealed class PlaylistControllerTest
    {
        private PlaylistController playlistController;
        private Mock<IPlaylistService> mockPlaylistService;

        [SetUp]
        public void Setup()
        {
            mockPlaylistService = new Mock<IPlaylistService>();
            playlistController = new PlaylistController(mockPlaylistService.Object);
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetAllAsync())
                .ReturnsAsync(It.IsAny<IEnumerable<Playlist>>())
                .Verifiable();

            // Act
            var result = await playlistController.GetAllAsync();

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetAllAsync())
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.GetAllAsync();

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(It.IsAny<Playlist>())
                .Verifiable();

            // Act
            var result = await playlistController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await playlistController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Playlist>>())
                .Verifiable();

            // Act
            var result = await playlistController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await playlistController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.CreateAsync(It.IsAny<Playlist>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await playlistController.CreateAsync(It.IsAny<Playlist>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<CreatedResult>());
            Assert.That((result as CreatedResult).StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.CreateAsync(It.IsAny<Playlist>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.CreateAsync(It.IsAny<Playlist>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Playlist>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await playlistController.CreateBulkAsync(It.IsAny<ICollection<Playlist>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<CreatedResult>());
            Assert.That((result as CreatedResult).StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Playlist>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.CreateBulkAsync(It.IsAny<ICollection<Playlist>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await playlistController.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await playlistController.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Playlist>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await playlistController.UpdateBulkAsync(It.IsAny<ICollection<Playlist>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Playlist>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await playlistController.UpdateBulkAsync(It.IsAny<ICollection<Playlist>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Playlist>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.UpdateBulkAsync(It.IsAny<ICollection<Playlist>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenDataExistThenDeletesData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await playlistController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NoContentResult>());
            Assert.That((result as NoContentResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await playlistController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenDataExistThenDeletesData()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await playlistController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NoContentResult>());
            Assert.That((result as NoContentResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await playlistController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockPlaylistService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await playlistController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockPlaylistService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }
    }
}
