using CSharp.UnitTesting.Api.Data.Entities.Base;
using System;

namespace CSharp.UnitTesting.Api.Data.Entities
{
    public class Subscription : Entity<Guid>
    {
        public int ChannelId { get; set; }

        public string UserEmail { get; set; }
        public DateTime SubscribedAt { get; set; }
    }
}
