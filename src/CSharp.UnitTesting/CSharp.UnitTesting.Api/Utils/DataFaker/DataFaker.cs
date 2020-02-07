using Bogus;
using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System;

namespace CSharp.UnitTesting.Api.Utils.DataFaker
{
    public sealed class DataFaker : IDataFaker
    {
        private const int COLLECTION_COUNT = 3;

        public Faker<Channel> FakeChannel =>
            new Faker<Channel>(locale: "en")
            .RuleFor(p => p.Id, f => f.Random.Int(min: 1))
            .RuleFor(p => p.Name, f => f.Random.String(minLength: 1, maxLength: 50))
            .RuleFor(p => p.Description, f => f.Random.String(minLength: 1, maxLength: 100))
            .RuleFor(p => p.Avatar, f => f.Random.Bytes(count: 1024))
            .RuleFor(p => p.OwnerEmail, f => f.Internet.Email())
            .RuleFor(p => p.Subscriptions, f => FakeSubscription.Generate(COLLECTION_COUNT))
            .RuleFor(p => p.Videos, f => FakeVideo.Generate(COLLECTION_COUNT))
            .RuleFor(p => p.IsDeleted, f => f.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);

        public Faker<Playlist> FakePlaylist =>
            new Faker<Playlist>(locale: "en")
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Name, f => f.Random.String(minLength: 1, maxLength: 50))
            .RuleFor(p => p.Description, f => f.Random.String(minLength: 1, maxLength: 100))
            .RuleFor(p => p.AccessType, f => f.PickRandom<PlaylistAccessType>())
            .RuleFor(p => p.CreatedAt, f => f.Date.Recent(days: 365, refDate: DateTime.UtcNow))
            .RuleFor(p => p.Videos, f => FakeVideo.Generate(COLLECTION_COUNT))
            .RuleFor(p => p.IsDeleted, f => f.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);

        public Faker<Subscription> FakeSubscription =>
            new Faker<Subscription>(locale: "en")
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.ChannelId, f => f.Random.Int(min: 1))
            .RuleFor(p => p.UserEmail, f => f.Internet.Email())
            .RuleFor(p => p.SubscribedAt, f => f.Date.Recent(days: 365, refDate: DateTime.UtcNow))
            .RuleFor(p => p.IsDeleted, f => f.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);

        public Faker<Video> FakeVideo =>
            new Faker<Video>(locale: "en")
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.ChannelId, f => f.Random.Int(min: 1))
            .RuleFor(p => p.Title, f => f.Random.String(minLength: 1, maxLength: 50))
            .RuleFor(p => p.Length, f => f.Random.Int(min: 1, max: 3600))
            .RuleFor(p => p.Thumbnail, f => f.Random.Bytes(count: 512))
            .RuleFor(p => p.AccessType, f => f.PickRandom<VideoAccessType>())
            .RuleFor(p => p.Url, f => f.Internet.Url())
            .RuleFor(p => p.PublishDate, f => f.Date.Recent(days: 365, refDate: DateTime.UtcNow))
            .RuleFor(p => p.IsDeleted, f => f.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);
    }
}
