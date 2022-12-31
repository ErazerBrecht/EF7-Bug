namespace EF7.MigrationBug.Models;

public abstract class ActivityProgramEventDocument : ActivityEventDocument
{
    public Guid ProgramId { get; init; }
}