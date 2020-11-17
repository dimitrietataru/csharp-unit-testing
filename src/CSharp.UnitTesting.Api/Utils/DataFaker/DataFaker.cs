using Bogus;
using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Data.Entities.Enums;
using CSharp.UnitTesting.Api.Utils.DataFaker.Interfaces;
using System;

namespace CSharp.UnitTesting.Api.Utils.DataFaker
{
    public sealed class DataFaker : IDataFaker
    {
        private const string LOCALE_CODE = "en";
        private const int COLLECTION_COUNT = 3;

        public Faker<Channel> FakeChannel =>
            new Faker<Channel>(locale: LOCALE_CODE)
            .RuleFor(
                property => property.Id,
                func => func.Random.Int(min: 1))
            .RuleFor(
                property => property.Name,
                func => func.Random.String(minLength: 1, maxLength: 50))
            .RuleFor(
                property => property.Description,
                func => func.Random.String(minLength: 1, maxLength: 100))
            .RuleFor(
                property => property.Avatar,
                func => func.Random.Bytes(count: 1024))
            .RuleFor(
                property => property.OwnerEmail,
                func => func.Internet.Email())
            .RuleFor(
                property => property.Subscriptions,
                _ => FakeSubscription.Generate(COLLECTION_COUNT))
            .RuleFor(
                property => property.Videos,
                _ => FakeVideo.Generate(COLLECTION_COUNT))
            .RuleFor(
                property => property.IsDeleted,
                func => func.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);

        public Faker<Playlist> FakePlaylist =>
            new Faker<Playlist>(locale: LOCALE_CODE)
            .RuleFor(
                property => property.Id,
                func => func.Random.Guid())
            .RuleFor(
                property => property.Name,
                func => func.Random.String(minLength: 1, maxLength: 50))
            .RuleFor(
                property => property.Description,
                func => func.Random.String(minLength: 1, maxLength: 100))
            .RuleFor(
                property => property.AccessType,
                func => func.PickRandom<PlaylistAccessType>())
            .RuleFor(
                property => property.CreatedAt,
                func => func.Date.Recent(days: 365, refDate: DateTime.UtcNow))
            .RuleFor(
                property => property.Videos,
                _ => FakeVideo.Generate(COLLECTION_COUNT))
            .RuleFor(
                property => property.IsDeleted,
                func => func.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);

        public Faker<Subscription> FakeSubscription =>
            new Faker<Subscription>(locale: LOCALE_CODE)
            .RuleFor(
                property => property.Id,
                func => func.Random.Guid())
            .RuleFor(
                property => property.ChannelId,
                func => func.Random.Int(min: 1))
            .RuleFor(
                property => property.UserEmail,
                func => func.Internet.Email())
            .RuleFor(
                property => property.SubscribedAt,
                func => func.Date.Recent(days: 365, refDate: DateTime.UtcNow))
            .RuleFor(
                property => property.IsDeleted,
                func => func.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);

        public Faker<Video> FakeVideo =>
            new Faker<Video>(locale: LOCALE_CODE)
            .RuleFor(
                property => property.Id,
                func => func.Random.Guid())
            .RuleFor(
                property => property.ChannelId,
                func => func.Random.Int(min: 1))
            .RuleFor(
                property => property.Title,
                func => func.Random.String(minLength: 1, maxLength: 50))
            .RuleFor(
                property => property.Length,
                func => func.Random.Int(min: 1, max: 3600))
            .RuleFor(
                property => property.Thumbnail,
                func => func.Random.Bytes(count: 512))
            .RuleFor(
                property => property.AccessType,
                func => func.PickRandom<VideoAccessType>())
            .RuleFor(
                property => property.Url,
                func => func.Internet.Url())
            .RuleFor(
                property => property.PublishDate,
                func => func.Date.Recent(days: 365, refDate: DateTime.UtcNow))
            .RuleFor(
                property => property.IsDeleted,
                func => func.Random.Bool(weight: 0.1F))
            .StrictMode(ensureRulesForAllProperties: true);
    }
}
