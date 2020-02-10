using CSharp.UnitTesting.Api.Controllers;
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
    [Trait("xUnit", "Controller | Video")]
    public class VideoControllerTest
    {
        private readonly Mock<IVideoService> mockVideoService;
        private readonly VideoController videoController;

        public VideoControllerTest()
        {
            mockVideoService = new Mock<IVideoService>();
            videoController = new VideoController(mockVideoService.Object);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetAllAsync())
                .ReturnsAsync(It.IsAny<IEnumerable<Video>>())
                .Verifiable();

            // Act
            var result = await videoController.GetAllAsync();

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetAllAsync())
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.GetAllAsync();

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(It.IsAny<Video>())
                .Verifiable();

            // Act
            var result = await videoController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Video>>())
                .Verifiable();

            // Act
            var result = await videoController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByChannelIdAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByChannelIdAsync(It.IsAny<int>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Video>>())
                .Verifiable();

            // Act
            var result = await videoController.GetByChannelIdAsync(It.IsAny<int>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByChannelIdAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByChannelIdAsync(It.IsAny<int>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.GetByChannelIdAsync(It.IsAny<int>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByChannelIdAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.GetByChannelIdAsync(It.IsAny<int>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.GetByChannelIdAsync(It.IsAny<int>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.CreateAsync(It.IsAny<Video>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await videoController.CreateAsync(It.IsAny<Video>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<CreatedResult>(result);
            Assert.Equal((int)HttpStatusCode.Created, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.CreateAsync(It.IsAny<Video>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.CreateAsync(It.IsAny<Video>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Video>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await videoController.CreateBulkAsync(It.IsAny<ICollection<Video>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<CreatedResult>(result);
            Assert.Equal((int)HttpStatusCode.Created, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Video>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.CreateBulkAsync(It.IsAny<ICollection<Video>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await videoController.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.UpdateAsync(It.IsAny<Video>(), It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Video>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await videoController.UpdateBulkAsync(It.IsAny<ICollection<Video>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<OkObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Video>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.UpdateBulkAsync(It.IsAny<ICollection<Video>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Video>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.UpdateBulkAsync(It.IsAny<ICollection<Video>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenDataExistThenDeletesData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await videoController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NoContentResult>(result);
            Assert.Equal((int)HttpStatusCode.NoContent, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenDataExistThenDeletesData()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await videoController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NoContentResult>(result);
            Assert.Equal((int)HttpStatusCode.NoContent, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await videoController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<NotFoundResult>(result);
            Assert.Equal((int)HttpStatusCode.NotFound, apiResponse.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockVideoService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await videoController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockVideoService.VerifyAll();
            var apiResponse = Assert.IsType<BadRequestResult>(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, apiResponse.StatusCode);
        }
    }
}
