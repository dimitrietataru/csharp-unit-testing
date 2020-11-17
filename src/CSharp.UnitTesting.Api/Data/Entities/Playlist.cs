using CSharp.UnitTesting.Api.Data.Entities.Base;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using System;
using System.Collections.Generic;

namespace CSharp.UnitTesting.Api.Data.Entities
{
    public class Playlist : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public PlaylistAccessType AccessType { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual IEnumerable<Video> Videos { get; set; } = new List<Video>();
    }
}
