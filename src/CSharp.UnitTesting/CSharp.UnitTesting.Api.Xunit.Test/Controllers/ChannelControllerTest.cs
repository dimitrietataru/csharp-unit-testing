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
    }
}
