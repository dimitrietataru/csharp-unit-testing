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
    }
}
