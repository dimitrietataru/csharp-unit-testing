﻿using CSharp.UnitTesting.Api.Controllers;
using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Controllers
{
    [Trait("xUnit", "Controller | Playlist")]
    public class PlaylistControllerTest
    {
        private readonly Mock<IPlaylistService> mockPlaylistService;
        private readonly PlaylistController playlistController;

        public PlaylistControllerTest()
        {
            mockPlaylistService = new Mock<IPlaylistService>();
            playlistController = new PlaylistController(mockPlaylistService.Object);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
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
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
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
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
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
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
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
            var apiResponse = Assert.IsType<CreatedResult>(result);
            Assert.Equal((int)HttpStatusCode.Created, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
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
            var apiResponse = Assert.IsType<CreatedResult>(result);
            Assert.Equal((int)HttpStatusCode.Created, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
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
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
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
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenDataExistThenDeletesData()
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
            var apiResponse = Assert.IsType<NoContentResult>(result);
            Assert.Equal((int)HttpStatusCode.NoContent, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenNoDataExistThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenDataExistThenDeletesData()
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
            var apiResponse = Assert.IsType<NoContentResult>(result);
            Assert.Equal((int)HttpStatusCode.NoContent, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenNoDataExistThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }
    }
}
