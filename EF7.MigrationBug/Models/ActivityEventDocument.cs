namespace EF7.MigrationBug.Models;

public abstract class ActivityEventDocument
{
    public Guid Id { get; init; }
    public Guid? UserId { get; init; }
    public long CreatedAt { get; init; }
}