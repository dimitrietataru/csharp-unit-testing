using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit | FluentAssertions", "Entity | Playlist")]
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
                playlist.Id.Should().NotBe(Guid.Empty, "because it is PK");
                playlist.Name.Should().NotBeNullOrEmpty("because it is required");
                playlist.Name.Length.Should().BeInRange(1, 50);
                playlist.Description.Should().NotBeNullOrEmpty("because it is required");
                playlist.Description.Length.Should().BeInRange(1, 100);
                playlist.AccessType.Should().NotBeNull("because it is required");
                playlist.CreatedAt.Should().BeOnOrAfter(DateTime.UtcNow.AddDays(-365));
                playlist.CreatedAt.Should().BeOnOrBefore(DateTime.UtcNow);
                playlist.Videos.Should().NotBeNullOrEmpty();
                playlist.Videos.Should().AllBeAssignableTo<Video>();
            });
        }
    }
}
