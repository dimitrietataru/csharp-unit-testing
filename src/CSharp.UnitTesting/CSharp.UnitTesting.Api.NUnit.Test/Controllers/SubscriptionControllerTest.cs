﻿using CSharp.UnitTesting.Api.Controllers;
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
    [Property("NUnit", "Subscription Controller")]
    public class SubscriptionControllerTest
    {
        private Mock<ISubscriptionService> mockSubscriptionService;
        private SubscriptionController subscriptionController;

        [SetUp]
        public void Setup()
        {
            mockSubscriptionService = new Mock<ISubscriptionService>();
            subscriptionController = new SubscriptionController(mockSubscriptionService.Object);
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetAllAsync())
                .ReturnsAsync(It.IsAny<IEnumerable<Subscription>>())
                .Verifiable();

            // Act
            var result = await subscriptionController.GetAllAsync();

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<ObjectResult>());
            var apiResponse = result as OkObjectResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetAllAsync())
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetAllAsync();

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(It.IsAny<Subscription>())
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var apiResponse = result as OkObjectResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByIdAsync(It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByIdAsync(It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Subscription>>())
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var apiResponse = result as OkObjectResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByIdsAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByIdsAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByChannelIdAsyncWhenDataExistThenReturnsData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByChannelIdAsync(It.IsAny<int>()))
                .ReturnsAsync(It.IsAny<IEnumerable<Subscription>>())
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByChannelIdAsync(It.IsAny<int>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var apiResponse = result as OkObjectResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByChannelIdAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByChannelIdAsync(It.IsAny<int>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByChannelIdAsync(It.IsAny<int>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "GET")]
        public async Task GivenGetByChannelIdAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.GetByChannelIdAsync(It.IsAny<int>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.GetByChannelIdAsync(It.IsAny<int>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.CreateAsync(It.IsAny<Subscription>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await subscriptionController.CreateAsync(It.IsAny<Subscription>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<CreatedResult>());
            var apiResponse = result as CreatedResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.CreateAsync(It.IsAny<Subscription>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.CreateAsync(It.IsAny<Subscription>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Subscription>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await subscriptionController.CreateBulkAsync(It.IsAny<ICollection<Subscription>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<CreatedResult>());
            var apiResponse = result as CreatedResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.Created));
        }

        [Test]
        [Property("HttpVerb", "POST")]
        public async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.CreateBulkAsync(It.IsAny<ICollection<Subscription>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.CreateBulkAsync(It.IsAny<ICollection<Subscription>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await subscriptionController.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var apiResponse = result as OkObjectResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.UpdateAsync(It.IsAny<Subscription>(), It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Subscription>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await subscriptionController.UpdateBulkAsync(It.IsAny<ICollection<Subscription>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            var apiResponse = result as OkObjectResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Subscription>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.UpdateBulkAsync(It.IsAny<ICollection<Subscription>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "PUT")]
        public async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.UpdateBulkAsync(It.IsAny<ICollection<Subscription>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.UpdateBulkAsync(It.IsAny<ICollection<Subscription>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenDataExistThenDeletesData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await subscriptionController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NoContentResult>());
            var apiResponse = result as NoContentResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.DeleteAsync(It.IsAny<Guid>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.DeleteAsync(It.IsAny<Guid>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenDataExistThenDeletesData()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await subscriptionController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NoContentResult>());
            var apiResponse = result as NoContentResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenNoDataExistThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<ApplicationException>()
                .Verifiable();

            // Act
            var result = await subscriptionController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
            var apiResponse = result as NotFoundResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.NotFound));
        }

        [Test]
        [Property("HttpVerb", "DELETE")]
        public async Task GivenDeleteBulkAsyncWhenExceptionThrownThenHandlesGracefully()
        {
            // Arrange
            mockSubscriptionService
                .Setup(_ => _.DeleteBulkAsync(It.IsAny<ICollection<Guid>>()))
                .Throws<Exception>()
                .Verifiable();

            // Act
            var result = await subscriptionController.DeleteBulkAsync(It.IsAny<ICollection<Guid>>());

            // Assert
            mockSubscriptionService.VerifyAll();
            Assert.That(result, Is.InstanceOf<BadRequestResult>());
            var apiResponse = result as BadRequestResult;
            Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.BadRequest));
        }
    }
}
