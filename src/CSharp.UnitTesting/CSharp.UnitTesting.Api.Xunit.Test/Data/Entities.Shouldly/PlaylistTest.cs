using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit | Shouldly", "Entities")]
    public class PlaylistTest
    {
        [Fact]
        [Trait("Entities", "Playlist")]
        internal void GivenPlaylistEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var playlists = dataFaker.FakePlaylist.Generate(count: 999);

            // Assert
            playlists.ForEach(
                playlist => playlist.ShouldSatisfyAllConditions(
                    () => playlist.Id.ShouldNotBeNull(),
                    () => playlist.Id.ShouldNotBe(Guid.Empty),
                    () => playlist.Name.ShouldNotBeNullOrEmpty(),
                    () => playlist.Name.Length.ShouldBeInRange(1, 50),
                    () => playlist.Description.ShouldNotBeNullOrEmpty(),
                    () => playlist.Description.Length.ShouldBeInRange(1, 100),
                    () => playlist.AccessType.ShouldNotBeNull(),
                    () => playlist.CreatedAt.ShouldBeGreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)),
                    () => playlist.CreatedAt.ShouldBeLessThanOrEqualTo(DateTime.UtcNow),
                    () => playlist.Videos.ShouldNotBeNull(),
                    () => playlist.Videos.ShouldBeAssignableTo<IEnumerable<Video>>(),
                    () => playlist.Videos.ShouldNotBeEmpty(),
                    () => playlist.IsDeleted.ShouldNotBeNull()));
        }
    }
}
