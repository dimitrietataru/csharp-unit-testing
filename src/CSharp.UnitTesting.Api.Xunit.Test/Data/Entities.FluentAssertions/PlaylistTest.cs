using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.FluentAssertions
{
    [Trait("xUnit + FluentAssertions | Data | Entities", nameof(Playlist))]
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
                playlist.Id.Should().NotBeEmpty();
                playlist.Name.Should().NotBeNullOrEmpty();
                playlist.Name.Length.Should().BeInRange(1, 50);
                playlist.Description.Should().NotBeNullOrEmpty();
                playlist.Description.Length.Should().BeInRange(1, 100);
                playlist.AccessType.Should().NotBeNull().And.BeOfType<PlaylistAccessType>();
                playlist.CreatedAt.Should().BeOnOrAfter(DateTime.UtcNow.AddDays(-365));
                playlist.CreatedAt.Should().BeOnOrBefore(DateTime.UtcNow);
                playlist.Videos.Should().NotBeNull().And.BeAssignableTo<IEnumerable<Video>>();
                playlist.Videos.Should().NotBeEmpty().And.HaveCount(3);
            });
        }
    }
}
