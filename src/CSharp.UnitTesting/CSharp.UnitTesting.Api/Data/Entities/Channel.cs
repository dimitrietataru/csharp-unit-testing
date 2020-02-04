using CSharp.UnitTesting.Api.Data.Entities.Base;
using System.Collections.Generic;

namespace CSharp.UnitTesting.Api.Data.Entities
{
    public class Channel : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Avatar { get; set; }
        public string OwnerEmail { get; set; }

        public virtual IEnumerable<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        public virtual IEnumerable<Video> Videos { get; set; } = new List<Video>();
    }
}
