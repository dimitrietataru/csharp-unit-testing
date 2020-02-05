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
    [Trait("xUnit", "Channel Controller")]
    public class ChannelControllerTest
    {
        private readonly Mock<IChannelService> mockChannelService;
        private readonly ChannelController channelController;

        public ChannelControllerTest()
        {
            mockChannelService = new Mock<IChannelService>();
            channelController = new ChannelController(mockChannelService.Object);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
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
            var result = Assert.IsType<OkObjectResult>(response);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
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
            var result = Assert.IsType<OkObjectResult>(response);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
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
            var result = Assert.IsType<NotFoundResult>(response);
            Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
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
            var result = Assert.IsType<OkObjectResult>(response);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
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
            var result = Assert.IsType<NotFoundResult>(response);
            Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetTopAsyncWhenDataExistThenReturnsData()
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
            var result = Assert.IsType<OkObjectResult>(response);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetTopAsyncWhenNoDataExistThenHandlesGracefully()
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
            var result = Assert.IsType<NotFoundResult>(response);
            Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetTopAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
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
            var result = Assert.IsType<CreatedResult>(response);
            Assert.Equal((int)HttpStatusCode.Created, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
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
            var result = Assert.IsType<CreatedResult>(response);
            Assert.Equal((int)HttpStatusCode.Created, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var response = await channelController.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            var result = Assert.IsType<OkObjectResult>(response);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var response = await channelController.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            var result = Assert.IsType<NotFoundResult>(response);
            Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.UpdateAsync(It.IsAny<Channel>(), It.IsAny<int>());

            // Assert
            mockChannelService.VerifyAll();
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Channel>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var response = await channelController.UpdateBulkAsync(It.IsAny<ICollection<Channel>>());

            // Assert
            mockChannelService.VerifyAll();
            var result = Assert.IsType<OkObjectResult>(response);
            Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Channel>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var response = await channelController.UpdateBulkAsync(It.IsAny<ICollection<Channel>>());

            // Assert
            mockChannelService.VerifyAll();
            var result = Assert.IsType<NotFoundResult>(response);
            Assert.Equal((int)HttpStatusCode.NotFound, result.StatusCode);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockChannelService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Channel>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var response = await channelController.UpdateBulkAsync(It.IsAny<ICollection<Channel>>());

            // Assert
            mockChannelService.VerifyAll();
            var result = Assert.IsType<BadRequestResult>(response);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
        }
    }
}
