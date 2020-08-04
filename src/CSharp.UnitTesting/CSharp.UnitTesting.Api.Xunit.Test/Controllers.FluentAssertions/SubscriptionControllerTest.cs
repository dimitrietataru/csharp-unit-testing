using CSharp.UnitTesting.Api.Controllers;
using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Controllers.FluentAssertions
{
    [Trait("xUnit + FluentAssertions | Controllers", nameof(SubscriptionController))]
    public sealed class SubscriptionControllerTest
    {
        private readonly SubscriptionController subscriptionController;
        private readonly Mock<ISubscriptionService> mockSubscriptionService;

        public SubscriptionControllerTest()
        {
            mockSubscriptionService = new Mock<ISubscriptionService>();
            subscriptionController = new SubscriptionController(mockSubscriptionService.Object);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenDataExistThenReturnsData()
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
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
            (result as OkObjectResult).StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetAllAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenDataExistThenReturnsData()
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
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
            (result as OkObjectResult).StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenDataExistThenReturnsData()
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
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
            (result as OkObjectResult).StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByIdsAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByChannelIdAsyncWhenDataExistThenReturnsData()
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
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
            (result as OkObjectResult).StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByChannelIdAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "GET")]
        internal async Task GivenGetByChannelIdAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenInputIsValidThenCreatesData()
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
            result.Should().NotBeNull().And.BeOfType<CreatedResult>();
            (result as CreatedResult).StatusCode.Should().Be((int)HttpStatusCode.Created);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenInputIsValidThenCreatesData()
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
            result.Should().NotBeNull().And.BeOfType<CreatedResult>();
            (result as CreatedResult).StatusCode.Should().Be((int)HttpStatusCode.Created);
        }

        [Fact]
        [Trait("HttpVerb", "POST")]
        internal async Task GivenCreateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenDataExistThenUpdatesData()
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
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
            (result as OkObjectResult).StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenDataExistThenUpdatesData()
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
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();
            (result as OkObjectResult).StatusCode.Should().Be((int)HttpStatusCode.OK);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "PUT")]
        internal async Task GivenUpdateBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenDataExistThenDeletesData()
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
            result.Should().NotBeNull().And.BeOfType<NoContentResult>();
            (result as NoContentResult).StatusCode.Should().Be((int)HttpStatusCode.NoContent);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenDataExistThenDeletesData()
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
            result.Should().NotBeNull().And.BeOfType<NoContentResult>();
            (result as NoContentResult).StatusCode.Should().Be((int)HttpStatusCode.NoContent);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenNoDataExistThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<NotFoundResult>();
            (result as NotFoundResult).StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }

        [Fact]
        [Trait("HttpVerb", "DELETE")]
        internal async Task GivenDeleteBulkAsyncWhenExceptionThrownThenHandlesGracefully()
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
            result.Should().NotBeNull().And.BeOfType<BadRequestResult>();
            (result as BadRequestResult).StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }
    }
}
