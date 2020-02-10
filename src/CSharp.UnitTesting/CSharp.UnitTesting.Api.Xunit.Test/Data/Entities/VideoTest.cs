using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities
{
    [Trait("xUnit", "Entities")]
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
                Assert.NotEqual(Guid.Empty, video.Id);
                Assert.InRange(video.ChannelId, 1, int.MaxValue);
                Assert.NotNull(video.Title);
                Assert.NotEmpty(video.Title);
                Assert.InRange(video.Title.Length, 1, 50);
                Assert.InRange(video.Length, 1, 3600);
                Assert.NotNull(video.Thumbnail);
                Assert.NotEmpty(video.Thumbnail);
                Assert.NotNull(video.Url);
                Assert.NotEmpty(video.Url);
                Assert.InRange(video.PublishDate, DateTime.UtcNow.AddDays(-365), DateTime.UtcNow);
            });
        }
    }
}
