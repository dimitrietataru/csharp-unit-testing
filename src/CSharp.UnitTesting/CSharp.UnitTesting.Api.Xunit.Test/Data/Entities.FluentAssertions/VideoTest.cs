using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit | FluentAssertions", "Entities")]
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
            videos.ForEach(video =>
            {
                video.Id.Should().NotBe(Guid.Empty, "because it is PK");
                video.ChannelId.Should().NotBe(null);
                video.ChannelId.Should().BeGreaterOrEqualTo(1, "because it is FK");
                video.Title.Length.Should().BeInRange(1, 50);
                video.Title.Should().NotBeNullOrEmpty("because it is required");
                video.Length.Should().BeInRange(1, 3600);
                video.Thumbnail.Should().NotBeNullOrEmpty("because it is required");
                video.AccessType.Should().NotBeNull("because it is required");
                video.Url.Should().NotBeNullOrEmpty("because it is required");
                video.PublishDate.Should().BeOnOrAfter(DateTime.UtcNow.AddDays(-365));
                video.PublishDate.Should().BeOnOrBefore(DateTime.UtcNow);
            });
        }
    }
}
