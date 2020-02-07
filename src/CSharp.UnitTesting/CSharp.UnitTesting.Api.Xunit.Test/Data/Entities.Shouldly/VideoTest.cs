﻿using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entities")]
    public class PlaVideoTestylistTest
    {
        [Fact]
        [Trait("Entities", "Video")]
        internal void GivenVideoEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var videos = dataFaker.FakeVideo.Generate(count: 999);

            // Assert
            videos.ForEach(
                video => video.ShouldSatisfyAllConditions(
                    () => video.Id.ShouldNotBeNull(),
                    () => video.Id.ShouldNotBe(Guid.Empty),
                    () => video.ChannelId.ShouldNotBeNull(),
                    () => video.ChannelId.ShouldBeGreaterThanOrEqualTo(1),
                    () => video.Title.ShouldNotBeNullOrEmpty(),
                    () => video.Title.Length.ShouldBeInRange(1, 50),
                    () => video.Length.ShouldNotBeNull(),
                    () => video.Length.ShouldBeInRange(1, 3600),
                    () => video.Thumbnail.ShouldNotBeNull(),
                    () => video.Thumbnail.Length.ShouldBeGreaterThanOrEqualTo(0),
                    () => video.AccessType.ShouldNotBeNull(),
                    () => video.Url.ShouldNotBeNullOrEmpty(),
                    () => video.PublishDate.ShouldNotBeNull(),
                    () => video.PublishDate.ShouldBeGreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)),
                    () => video.PublishDate.ShouldBeLessThanOrEqualTo(DateTime.UtcNow),
                    () => video.IsDeleted.ShouldNotBeNull()));
        }
    }
}
