using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entity | Video")]
    public class PlaVideoTestylistTest
    {
        [Fact]
        internal void GivenVideoEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var videos = dataFaker.FakeVideo.Generate(count: 99);

            // Assert
            videos.ForEach(
                video => video.ShouldSatisfyAllConditions(
                    () => video.Id.ShouldNotBeNull(),
                    () => video.Id.ShouldNotBe(Guid.Empty, "because it is PK"),
                    () => video.ChannelId.ShouldNotBeNull(),
                    () => video.ChannelId.ShouldBeGreaterThanOrEqualTo(1, "because it is FK"),
                    () => video.Title.ShouldNotBeNullOrEmpty("because it is required"),
                    () => video.Title.Length.ShouldBeInRange(1, 50),
                    () => video.Length.ShouldNotBeNull("because it is required"),
                    () => video.Length.ShouldBeInRange(1, 3600),
                    () => video.Thumbnail.ShouldNotBeNull("because it is required"),
                    () => video.Thumbnail.ShouldNotBeEmpty(),
                    () => video.AccessType.ShouldNotBeNull("because it is required"),
                    () => video.Url.ShouldNotBeNullOrEmpty("because it is required"),
                    () => video.PublishDate.ShouldNotBeNull(),
                    () => video.PublishDate.ShouldBeInRange(DateTime.UtcNow.AddDays(-365), DateTime.UtcNow),
                    () => video.IsDeleted.ShouldNotBeNull("because it is required")));
        }
    }
}
