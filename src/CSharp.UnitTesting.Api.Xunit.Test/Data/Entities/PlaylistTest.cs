using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities
{
    [Trait("xUnit + Default | Data | Entities", nameof(Playlist))]
    public sealed class PlaylistTest
    {
        [Fact]
        internal void GivenPlaylistEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var playlists = dataFaker.FakePlaylist.Generate(count: 10);

            // Assert
            playlists.ForEach(playlist =>
            {
                Assert.NotEqual(Guid.Empty, playlist.Id);
                Assert.NotNull(playlist.Name);
                Assert.NotEmpty(playlist.Name);
                Assert.InRange(playlist.Name.Length, 1, 50);
                Assert.NotNull(playlist.Description);
                Assert.NotEmpty(playlist.Description);
                Assert.InRange(playlist.Description.Length, 1, 100);
                Assert.IsType<PlaylistAccessType>(playlist.AccessType);
                Assert.InRange(playlist.CreatedAt, DateTime.UtcNow.AddDays(-365), DateTime.UtcNow);
                Assert.NotNull(playlist.Videos);
                Assert.IsAssignableFrom<IEnumerable<Video>>(playlist.Videos);
                Assert.NotEmpty(playlist.Videos);
                Assert.Equal(3, playlist.Videos.Count());
                Assert.IsType<bool>(playlist.IsDeleted);
            });
        }
    }
}
