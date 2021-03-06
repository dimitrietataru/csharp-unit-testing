﻿using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using NUnit.Framework;
using System;

namespace CSharp.UnitTesting.Api.NUnit.Test.Data.Entities
{
    [Property("NUnit + Default | Data | Entities", nameof(Video))]
    public sealed class VideoTest
    {
        [Test]
        public void GivenVideoEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var videos = dataFaker.FakeVideo.Generate(count: 10);

            // Assert
            videos.ForEach(video =>
            {
                Assert.That(video.Id, Is.Not.Null);
                Assert.That(video.Id, Is.Not.EqualTo(Guid.Empty));
                Assert.That(video.ChannelId, Is.Not.Null);
                Assert.That(video.ChannelId, Is.GreaterThanOrEqualTo(1));
                Assert.That(video.Title, Is.Not.Null);
                Assert.That(video.Title, Is.Not.Empty);
                Assert.That(video.Title.Length, Is.InRange(1, 50));
                Assert.That(video.Length, Is.Not.Null);
                Assert.That(video.Length, Is.InRange(1, 3600));
                Assert.That(video.Thumbnail, Is.Not.Null);
                Assert.That(video.Thumbnail, Is.Not.Empty);
                Assert.That(video.AccessType, Is.Not.Null);
                Assert.That(video.AccessType, Is.TypeOf<VideoAccessType>());
                Assert.That(video.Url, Is.Not.Null);
                Assert.That(video.Url, Is.Not.Empty);
                Assert.That(video.PublishDate, Is.Not.Null);
                Assert.That(video.PublishDate, Is.GreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)));
                Assert.That(video.PublishDate, Is.LessThanOrEqualTo(DateTime.UtcNow));
                Assert.That(video.IsDeleted, Is.Not.Null);
                Assert.That(video.IsDeleted, Is.TypeOf<bool>());
            });
        }
    }
}
