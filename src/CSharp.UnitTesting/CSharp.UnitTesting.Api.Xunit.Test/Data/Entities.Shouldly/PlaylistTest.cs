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
        internal void GivenPlaylistEntityWhenGeneratedWithDataFakerThenVerifyAllProperties()
        {
            // Arrange
            IDataFaker dataFaker = new DataFaker();

            // Act
            var playlists = dataFaker.FakePlaylist.Generate(count: 99);

            // Assert
            playlists.ForEach(
                playlist => playlist.ShouldSatisfyAllConditions(
                    () => playlist.Id.ShouldNotBeNull(),
                    () => playlist.Id.ShouldNotBe(Guid.Empty, "because it is PK"),
                    () => playlist.Name.ShouldNotBeNullOrEmpty("because it is required"),
                    () => playlist.Name.Length.ShouldBeInRange(1, 50),
                    () => playlist.Description.ShouldNotBeNullOrEmpty("because it is required"),
                    () => playlist.Description.Length.ShouldBeInRange(1, 100),
                    () => playlist.AccessType.ShouldNotBeNull("because it is required"),
                    () => playlist.CreatedAt.ShouldBeGreaterThanOrEqualTo(DateTime.UtcNow.AddDays(-365)),
                    () => playlist.CreatedAt.ShouldBeLessThanOrEqualTo(DateTime.UtcNow),
                    () => playlist.Videos.ShouldNotBeNull(),
                    () => playlist.Videos.ShouldNotBeEmpty(),
                    () => playlist.Videos.ShouldBeAssignableTo<IEnumerable<Video>>(),
                    () => playlist.IsDeleted.ShouldNotBeNull("because it is required")));
        }
    }
}
