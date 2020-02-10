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
        [Trait("Entities", "Video")]
        internal void GivenVideoEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var videos = dataFaker.FakeVideo.Generate(count: 99);

            // Assert
            videos.ForEach(video =>
            {
                ////Assert.NotNull(video.Id);
                Assert.NotEqual(Guid.Empty, video.Id);
                ////Assert.NotNull(video.ChannelId);
                Assert.True(video.ChannelId >= 1);
                Assert.NotNull(video.Title);
                Assert.NotEmpty(video.Title);
                Assert.True(video.Title.Length >= 1);
                Assert.True(video.Title.Length <= 50);
                ////Assert.NotNull(video.Length);
                Assert.True(video.Length >= 1);
                Assert.True(video.Length <= 3600);
                Assert.NotNull(video.Thumbnail);
                Assert.True(video.Thumbnail.Length >= 0);
                Assert.NotNull(video.Url);
                Assert.NotEmpty(video.Url);
                ////Assert.NotNull(video.AccessType);
                ////Assert.NotNull(video.PublishDate);
                Assert.True(video.PublishDate >= DateTime.UtcNow.AddDays(-365));
                Assert.True(video.PublishDate <= DateTime.UtcNow);
                ////Assert.NotNull(video.IsDeleted);
            });
        }
    }
}
