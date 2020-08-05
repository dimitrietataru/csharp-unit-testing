using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit + FluentAssertions | Data | Entities", nameof(Video))]
    public sealed class PlaVideoTestylistTest
    {
        [Fact]
        internal void GivenVideoEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var videos = dataFaker.FakeVideo.Generate(count: 10);

            // Assert
            videos.ForEach(video =>
            {
                video.Id.Should().NotBeEmpty();
                video.ChannelId.Should().NotBe(null).And.BeGreaterOrEqualTo(1);
                video.Title.Should().NotBeNullOrEmpty();
                video.Title.Length.Should().BeInRange(1, 50);
                video.Length.Should().BeInRange(1, 3600);
                video.Thumbnail.Should().NotBeNullOrEmpty();
                video.AccessType.Should().NotBeNull().And.BeOfType<VideoAccessType>();
                video.Url.Should().NotBeNullOrEmpty();
                video.PublishDate.Should().BeOnOrAfter(DateTime.UtcNow.AddDays(-365));
                video.PublishDate.Should().BeOnOrBefore(DateTime.UtcNow);
            });
        }
    }
}
