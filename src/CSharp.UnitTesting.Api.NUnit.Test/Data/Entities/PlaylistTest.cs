using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CSharp.UnitTesting.Api.NUnit.Test.Data.Entities
{
    [Property("NUnit + Default | Data | Entities", nameof(Playlist))]
    public sealed class PlaylistTest
    {
        [Test]
        public void GivenPlaylistEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var playlists = dataFaker.FakePlaylist.Generate(count: 10);

            // Assert
            playlists.ForEach(playlist =>
            {
                Assert.That(playlist.Id, Is.Not.Null);
                Assert.That(playlist.Id, Is.Not.EqualTo(Guid.Empty));
                Assert.That(playlist.Name, Is.Not.Null);
                Assert.That(playlist.Name, Is.Not.Empty);
                Assert.That(playlist.Name.Length, Is.InRange(1, 50));
                Assert.That(playlist.Description, Is.Not.Null);
                Assert.That(playlist.Description, Is.Not.Empty);
                Assert.That(playlist.Description.Length, Is.InRange(1, 100));
                Assert.That(playlist.AccessType, Is.Not.Null);
                Assert.That(playlist.AccessType, Is.TypeOf<PlaylistAccessType>());
                Assert.That(playlist.CreatedAt, Is.Not.Null);
                Assert.That(playlist.CreatedAt, Is.GreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)));
                Assert.That(playlist.CreatedAt, Is.LessThanOrEqualTo(DateTime.UtcNow));
                Assert.That(playlist.Videos, Is.Not.Null);
                Assert.That(playlist.Videos, Is.InstanceOf<IEnumerable<Video>>());
                Assert.That(playlist.Videos, Is.Not.Empty);
                Assert.That(playlist.Videos, Has.Count.EqualTo(3));
                Assert.That(playlist.IsDeleted, Is.Not.Null);
                Assert.That(playlist.IsDeleted, Is.TypeOf<bool>());
            });
        }
    }
}
