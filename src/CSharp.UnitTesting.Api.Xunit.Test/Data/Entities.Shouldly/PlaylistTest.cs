using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharp.UnitTesting.Api.Xunit.Test.Data.Entities.Shouldly
{
    [Trait("xUnit + Shouldly | Data | Entities", nameof(Playlist))]
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
            playlists.ForEach(
                playlist => playlist.ShouldSatisfyAllConditions(
                    () => playlist.Id.ShouldNotBe(Guid.Empty),
                    () => playlist.Name.ShouldNotBeNullOrEmpty(),
                    () => playlist.Name.Length.ShouldBeInRange(1, 50),
                    () => playlist.Description.ShouldNotBeNullOrEmpty(),
                    () => playlist.Description.Length.ShouldBeInRange(1, 100),
                    () => playlist.AccessType.ShouldBeOfType<PlaylistAccessType>(),
                    () => playlist.CreatedAt.ShouldBeGreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)),
                    () => playlist.CreatedAt.ShouldBeLessThanOrEqualTo(DateTime.UtcNow),
                    () => playlist.Videos.ShouldNotBeNull(),
                    () => playlist.Videos.ShouldNotBeEmpty(),
                    () => playlist.Videos.ShouldBeAssignableTo<IEnumerable<Video>>(),
                    () => playlist.Videos.Count().ShouldBe(3),
                    () => playlist.IsDeleted.ShouldBeOneOf(true, false)));
        }
    }
}
