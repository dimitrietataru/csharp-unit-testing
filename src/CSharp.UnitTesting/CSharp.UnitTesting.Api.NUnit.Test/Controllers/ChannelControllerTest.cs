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
    [Property("NUnit", "Channel Controller")]
    public class ChannelControllerTest
    {
        private Mock<IChannelService> mockChannelService;
        private ChannelController channelController;

        [SetUp]
        public void Setup()
        {
            mockChannelService = new Mock<IChannelService>();
            channelController = new ChannelController(mockChannelService.Object);
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetAllAsync())
                .ReturnsAsync(It.IsAny<IEnumerable<Channel>>())
                .Verifiable();

            // Act
            var response = await channelController.GetAllAsync();

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<ObjectResult>());
            var result = response as OkObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetAllAsync())
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.GetAllAsync();

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<BadRequestResult>());
            var result = response as BadRequestResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(It.IsAny<Channel>())
                .Verifiable();

            // Act
            var response = await channelController.GetByIdAsync(It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<OkObjectResult>());
            var result = response as OkObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetByIdAsync(It.IsAny<int>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var response = await channelController.GetByIdAsync(It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<NotFoundResult>());
            var result = response as NotFoundResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetByIdAsync(It.IsAny<int>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.GetByIdAsync(It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<BadRequestResult>());
            var result = response as BadRequestResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<int>>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Channel>>())
                .Verifiable();

            // Act
            var response = await channelController.GetByIdsAsync(It.IsAny<ICollection<int>>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<OkObjectResult>());
            var result = response as OkObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<int>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var response = await channelController.GetByIdsAsync(It.IsAny<ICollection<int>>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<NotFoundResult>());
            var result = response as NotFoundResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<int>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.GetByIdsAsync(It.IsAny<ICollection<int>>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<BadRequestResult>());
            var result = response as BadRequestResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetTopAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetTopAsync(It.IsAny<int>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Channel>>())
                .Verifiable();

            // Act
            var response = await channelController.GetTopAsync(It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<OkObjectResult>());
            var result = response as OkObjectResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetTopAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetTopAsync(It.IsAny<int>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var response = await channelController.GetTopAsync(It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<NotFoundResult>());
            var result = response as NotFoundResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetTopAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.GetTopAsync(It.IsAny<int>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.GetTopAsync(It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<BadRequestResult>());
            var result = response as BadRequestResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.CreateAsync(It.IsAny<Channel>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var response = await channelController.CreateAsync(It.IsAny<Channel>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<CreatedResult>());
            var result = response as CreatedResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.CreateAsync(It.IsAny<Channel>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.CreateAsync(It.IsAny<Channel>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<BadRequestResult>());
            var result = response as BadRequestResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Channel>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var response = await channelController.CreateBulkAsync(It.IsAny<ICollection<Channel>>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<CreatedResult>());
            var result = response as CreatedResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Channel>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.CreateBulkAsync(It.IsAny<ICollection<Channel>>());

            // Assert
            mockChannelService.VerifyAll();
            Assert.That(response, Is.InstanceOf<BadRequestResult>());
            var result = response as BadRequestResult;
            Assert.That(result.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }
    }
}
