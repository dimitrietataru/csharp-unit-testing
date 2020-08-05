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
    [Property("NUnit + Default | Controllers", nameof(VideoController))]
    public sealed class VideoControllerTest
    {
        private VideoController videoController;
        private Mock<IVideoService> mockVideoService;

        [SetUp]
        public void Setup()
        {
            mockVideoService = new Mock<IVideoService>();
            videoController = new VideoController(mockVideoService.Object);
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
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
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
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
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
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
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByChannelIdAsyncWhenDataExistThenReturnsData()
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
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByChannelIdAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByChannelIdAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
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
            Assert.That(result, Is.InstanceOf<CreatedResult>());
            Assert.That((result as CreatedResult).StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
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
            Assert.That(result, Is.InstanceOf<CreatedResult>());
            Assert.That((result as CreatedResult).StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
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
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
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
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That((result as OkObjectResult).StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenDataExistThenDeletesData()
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
            Assert.That(result, Is.InstanceOf<NoContentResult>());
            Assert.That((result as NoContentResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenDataExistThenDeletesData()
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
            Assert.That(result, Is.InstanceOf<NoContentResult>());
            Assert.That((result as NoContentResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenNoDataExistThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            Assert.That((result as NotFoundResult).StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            Assert.That((result as BadRequestResult).StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }
    }
}
