using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities
{
    [Trait("xUnit", "Entities")]
    public class PlaylistTest
    {
        [Fact]
        internal void GivenPlaylistEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var playlists = dataFaker.FakePlaylist.Generate(count: 99);

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
                Assert.InRange(playlist.CreatedAt, DateTime.UtcNow.AddDays(-365), DateTime.UtcNow);
                Assert.NotNull(playlist.Videos);
                Assert.NotEmpty(playlist.Videos);
                Assert.IsAssignableFrom<IEnumerable<Video>>(playlist.Videos);
            });
        }
    }
}
