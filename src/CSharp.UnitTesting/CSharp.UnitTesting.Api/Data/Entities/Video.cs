using CSharp.UnitTesting.Api.Data.Entities.Base;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using System;

namespace CSharp.UnitTesting.Api.Data.Entities
{
    public class Video : Entity<Guid>
    {
        public int ChannelId { get; set; }

        public string Title { get; set; }
        public int Length { get; set; }
        public byte[] Thumbnail { get; set; }
        public VideoAccessType AccessType { get; set; }
        public string Url { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
