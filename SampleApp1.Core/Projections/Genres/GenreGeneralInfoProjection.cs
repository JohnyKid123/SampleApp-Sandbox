namespace SampleApp1.Core.Projections.Genres
{
    public record GenreGeneralInfoProjection
    {
        public required Guid Id { get; init; }
        public required string Name { get; init; }
        public required long ArtistsCount { get; init; }
        public required long SongsCount { get; init; }
    }
}
